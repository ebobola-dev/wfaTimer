using Timer = System.Windows.Forms.Timer;

namespace wfaTimer
{
    public partial class Form1 : Form
    {
        private const int DEFAULT_TIMER_VALUE = 5; //? in seconds
        private int timerValue = DEFAULT_TIMER_VALUE;
        private Timer timer = new();
        private DateTime startTime;
        private DateTime pauseTime;
        private bool wasFinished = false;


        public Form1() {
            InitializeComponent();
            timer.Interval = 16;
            timer.Tick += Timer_Tick;

            //? Заполняем комбобоксы вариантами
            for (int i = 0; i < 100; i++) {
                comboHours.Items.Add($"{i}");
                if (i < 60) {
                    comboMinutes.Items.Add($"{i}");
                    comboSeconds.Items.Add($"{i}");
                }
            }

            //? Выбираем в комбобоксах значения
            calculateDefaultSeconds();
        }

        //? Высчитываем секунды -> часы, минуты и секунды для начальных значений комбобоксов
        private void calculateDefaultSeconds() {
            int tempTimerValue = timerValue;
            int hours = tempTimerValue / 3600;
            if (hours > 99) hours = 99;
            comboHours.SelectedIndex = hours;

            int minutes = tempTimerValue / 60 - 60 * hours;
            comboMinutes.SelectedIndex = minutes;

            int seconds = tempTimerValue % 60;
            comboSeconds.SelectedIndex = seconds;
        }

        //? Вызываем каждый раз при изменении значений в каком-нибудь комбобоксе
        //? Высчитываем, часы, минуты и секунды -> секунды
        private void calculateComboBoxesData() {
            int hours = comboHours.SelectedIndex;
            int minutes = comboMinutes.SelectedIndex;
            int seconds = comboSeconds.SelectedIndex;
            if (hours < 0) hours = 0;
            if (minutes < 0) minutes = 0;
            if (seconds < 0) seconds = 0;
            timerValue = seconds + minutes * 60 + hours * 3600;

            //? Подстраиваем ui под новые значения
            progressBar.Maximum = timerValue * 1000;
            progressBar.Value = 0;
            timerLabel.Text = "00:00:00.00";
            reverseProgressBar.Maximum = timerValue * 1000;
            reverseProgressBar.Value = timerValue * 1000;
            reverseTimerLabel.Text = TimeSpan.FromSeconds(timerValue).ToString(@"hh\:mm\:ss\.ff");
            percentLabel.Text = "0%";
            //? Если 0 секунд, то таймер запустить нельзя
            startButton.Enabled = timerValue != 0;
        }

        //? Отключение/включение комбобоксов (они недоступны пока таймер работает или стоит на паузе)
        private void changeComboBoxesEnabled(bool enabled) {
            comboHours.Enabled = enabled;
            comboMinutes.Enabled = enabled;
            comboSeconds.Enabled = enabled;
        }

        //? Запуск таймера (или снятие с паузы)
        private void startTimer() {

            //? Если в прошлый раз таймер отсчитал до конца, перед след запуском его надо перезапустить полностью (функ. resetTimer), иначе все наъуй сломается
            if (wasFinished) {
                resetTimer();
                wasFinished = false;
            }
            startButton.Text = "Пауза";
            startTime = startTime + (DateTime.Now - pauseTime);
            timer.Start();
            //? Выключаем комбобоксы
            changeComboBoxesEnabled(false);
        }

        //? Пауза таймера
        private void pauseTimer() {
            startButton.Text = "Продолжить";
            pauseTime = DateTime.Now;
            timer.Stop();
        }

        //? Сброс таймера (все приводим в начальные значения)
        private void resetTimer() {
            timer.Stop();
            startButton.Text = "Старт";
            timerLabel.Text = "00:00:00.00";
            percentLabel.Text = "0%";
            progressBar.Value = 0;
            reverseProgressBar.Value = timerValue * 1000;
            reverseTimerLabel.Text = TimeSpan.FromSeconds(timerValue).ToString(@"hh\:mm\:ss\.ff");
            startTime = DateTime.Now;
            pauseTime = DateTime.Now;
            //? Включаем комбобоксы
            changeComboBoxesEnabled(true);
        }

        //? Вызывается, когда таймер успешно досчитал до конца
        private void onFinishTimer() {
            wasFinished = true;
            timer.Stop();
            startButton.Text = "Старт";
            //? Включаем комбобоксы
            changeComboBoxesEnabled(true);
        }

        private void Timer_Tick(object? sender, EventArgs e) {
            var passedTime = DateTime.Now - startTime; //? Сколько прошло времени 
            var leftTime = TimeSpan.FromSeconds(timerValue) - passedTime; //? Сколько осталось времени
            var percentValue = (int)(passedTime.TotalSeconds / timerValue * 100); //? Сколько прошло времени в процентах

            //? Эти значения каким-то образом чучуть выходят за границы дозволенного, поэтому обрезаем
            if (percentValue > 100) percentValue = 100;
            if (leftTime.TotalMilliseconds < 0) leftTime = TimeSpan.FromSeconds(0);

            //? Если досчитали до конца
            if (passedTime.TotalSeconds > timerValue) {
                onFinishTimer();
                passedTime = TimeSpan.FromSeconds(timerValue);
            }
            timerLabel.Text = passedTime.ToString(@"hh\:mm\:ss\.ff");
            reverseTimerLabel.Text = leftTime.ToString(@"hh\:mm\:ss\.ff");
            progressBar.Value = (int)passedTime.TotalMilliseconds;
            reverseProgressBar.Value = (int)leftTime.TotalMilliseconds;
            percentLabel.Text = String.Format("{0:0.##}", percentValue) + "%";
        }

        private void startButton_Click(object? sender, EventArgs e) {
            if (timer.Enabled) {
                pauseTimer();
            } else {
                startTimer();
            }
        }

        private void resetButton_Click(object sender, EventArgs e) {
            resetTimer();
        }

        private void comboHours_SelectedIndexChanged(object sender, EventArgs e) {
            calculateComboBoxesData();
        }

        private void comboMinutes_SelectedIndexChanged(object sender, EventArgs e) {
            calculateComboBoxesData();
        }

        private void comboSeconds_SelectedIndexChanged(object sender, EventArgs e) {
            calculateComboBoxesData();
        }
    }
}