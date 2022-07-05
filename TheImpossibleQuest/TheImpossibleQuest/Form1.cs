using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using System.Net;


namespace TheImpossibleQuest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void choosebutton1_Click(object sender, EventArgs e)
        {
            if (story.Text == "Ты победил! Может теперь в настоящую игру поиграем?")
            {
                story.Text = "Молодчина, доехал до конца!";
                choosebutton1.Visible = false;
                choosebutton2.Visible = false;
                choosebutton3.Visible = false;
                Restart.Visible = true;
            }
            if (story.Text == "Во что будем играть?")
            {
                story.Text = "Молодчина, доехал до конца!";
                choosebutton1.Visible = false;
                choosebutton2.Visible = false;
                choosebutton3.Visible = false;
                Restart.Visible = true;
            }
            if (story.Text == "Ты победил! Может теперь в настоящую игру поиграем?")
            {
                story.Text = "Молодчина, доехал до конца!";
                choosebutton1.Visible = false;
                choosebutton2.Visible = false;
                choosebutton3.Visible = false;
                Restart.Visible = true;
            }
            if (story.Text == "Калькулятор? Ну хорошо. Выбери 'уровень'.")
            {
                story.Text = "Ты победил! Может теперь в настоящую игру поиграем?";
                choosebutton1.Text = "Гонки";
                choosebutton2.Text = "Невозможный квест";
                choosebutton3.Text = "Нет, лучше посплю";
            }
            if (story.Text == "'Чувак, вернись на место, лучше не шути с Чаком.'")
            {
                story.Text = "Вы благополучно долетели до пункта своего назначения!";
                choosebutton1.Visible = false;
                choosebutton2.Visible = false;
                choosebutton3.Visible = false;
                Restart.Visible = true;
            }
            if (story.Text == "Аккуратно пройдя через салон, но всё же задев ноги всех пассажиров, ты подходишь к туалету. 'Занято!',- ответили тебе на попытку открыть дверь.")
            {
                story.Text = "'Чувак, вернись на место, лучше не шути с Чаком.'";
                choosebutton1.Text = "Вернуться на место и уснуть";
                choosebutton2.Text = "Да мне пофиг кто ты, вышел, я сказал!";
                choosebutton3.Text = "Хаха, Чак - дебильное имя!";
            }
            if (story.Text == "'А не прилипнет потом у вас кое-что к креслу? Давайте скромнее выбирайте'")
            {
                story.Text = "Ты немножко поел, после чего случилось то, что часто происходит с людьми в самолете: тебе стало скучно.";
                choosebutton1.Text = "Сходить в туалет";
                choosebutton2.Text = "Поиграть на ноутбуке";
                choosebutton3.Text = "Поспать";
            }
            if (story.Text == "Ты немножко поел, после чего случилось то, что часто происходит с людьми в самолете: тебе стало скучно.")
            {
                story.Text = "Аккуратно пройдя через салон, но всё же задев ноги всех пассажиров, ты подходишь к туалету. 'Занято!',- ответили тебе на попытку открыть дверь.";
                choosebutton1.Text = "Слышь, давай выходи!";
                choosebutton2.Text = "Вернуться на место и уснуть";
                choosebutton3.Text = "А ну быстро вышел!";
            }
            if (story.Text == "Через некоторое время к тебе подошла стюардесса. 'Сегодня на ужин у нас выбор мясо или рыба. Что желаете?")
            {
                story.Text = "Ты немножко поел, после чего случилось то, что часто происходит с людьми в самолете: тебе стало скучно.";
                choosebutton1.Text = "Сходить в туалет";
                choosebutton2.Text = "Поиграть на ноутбуке";
                choosebutton3.Text = "Поспать";
            }
            if (story.Text == "'No more.' Толстяк дал тебе пять и опять уснул")
            {
                story.Text = "Через некоторое время к тебе подошла стюардесса. 'Сегодня на ужин у нас выбор мясо или рыба. Что желаете?";
                choosebutton1.Text = "Мясо";
                choosebutton2.Text = "Рыбу";
                choosebutton3.Text = "Хочу пирожное, хочу мороженое!";
            }
            if (story.Text == "'Baby don't hurt me',- пропел он в ответ.")
            {
                story.Text = "'No more.' Толстяк дал тебе пять и опять уснул";
                choosebutton1.Text = "Толстяк ваще зачетный";
                choosebutton2.Text = "Спокойно сидеть в кресле";
                choosebutton3.Text = "Почитать брошюрку об аварийной посадке";
            }
            if (story.Text == "'Милейший, нет никакой нужды так выражаться, вам впредь стоит выбирать выражения. Ваше общество угнетает меня, пожалуй я пересяду',-сказал толстяк и ушёл.")
            {
                story.Text = "Через некоторое время к тебе подошла стюардесса. 'Сегодня на ужин у нас выбор мясо или рыба. Что желаете?";
                choosebutton1.Text = "Мясо";
                choosebutton2.Text = "Рыбу";
                choosebutton3.Text = "Хочу пирожное, хочу мороженое!";
            }
            if (story.Text == "Его нога похожа на маленького кита, просто так ее не сдвинутью.")
            {
                story.Text = "Через некоторое время к тебе подошла стюардесса. 'Сегодня на ужин у нас выбор мясо или рыба. Что желаете?";
                choosebutton1.Text = "Мясо";
                choosebutton2.Text = "Рыбу";
                choosebutton3.Text = "Хочу пирожное, хочу мороженое!";
            }
            if (story.Text == "Ты просыпаешься в самолетном кресле.За окном белые,как пена,облака.Рядом с тобой храпит какой-то толстяк,его нога уперлась в твою ногу.")
            {
                story.Text = "Его нога похожа на маленького кита, просто так ее не сдвинутью.";
                choosebutton1.Text = "Терпеть неудобства как лох";
                choosebutton2.Text = "Разбудить толстяка";
                choosebutton3.Text = "Разбудить толстяка матом";
            }
            if (story.Text == "'Ой, великодушный, крайне извиняюсь',- сказал он, после чего отодвинул ногу и вновь уснул. Ну вот, а так хотелось конфликта.")
            {
                story.Text = "Ну и какую глупость ты хочешь устроить?";
                choosebutton1.Text = "Прыгнуть с самолёта";
                choosebutton2.Text = "Наорать на толстяка";
                choosebutton3.Text = "Перестать хотеть устроить конфликт";
            }
            if (story.Text == "Что будем спрашивать?")
            {
                story.Text = "'Ой, великодушный, крайне извиняюсь',- сказал он, после чего отодвинул ногу и вновь уснул. Ну вот, а так хотелось конфликта.";
                choosebutton1.Text = "Устроить конфликт";
                choosebutton2.Text = "Спокойно сидеть в кресле";
                choosebutton3.Text = "Почитать брошюрку об аварийной посадке";
            }
            if (story.Text == "Ты незаметно пробрался к аварийной двери, а после рывком открыл её. Сильный поток воздуха вышвыривает тебя за борт. Молодец, ты добился своейго.")
            {
                story.Text = "Ты разбился насмерть. Как так получилось, даже не знаю.";
                choosebutton1.Visible = false;
                choosebutton2.Visible = false;
                choosebutton3.Visible = false;
                Restart.Visible = true;
            }
            if (story.Text == "Ну и какую глупость ты хочешь устроить?")
            {
                story.Text = "Ты незаметно пробрался к аварийной двери, а после рывком открыл её. Сильный поток воздуха вышвыривает тебя за борт. Молодец, ты добился своейго.";
                choosebutton1.Text = "Падать солдатиком";
                choosebutton2.Text = "Падать бомбочкой";
                choosebutton3.Text = "Подумать о выгодности своих действий";
            }
            if (story.Text == "Ты легонько хлопаешь толстяка по плечу. Издав последний громкий храп, он проснулся. 'Слышь,чего тебе?'")
            {
                story.Text = "'Ой, великодушный, крайне извиняюсь',- сказал он, после чего отодвинул ногу и вновь уснул. Ну вот, а так хотелось конфликта.";
                choosebutton1.Text = "Устроить конфликт";
                choosebutton2.Text = "Спокойно сидеть в кресле";
                choosebutton3.Text = "Почитать брошюрку об аварийной посадке";
            }
        }

        private void choosebutton2_Click(object sender, EventArgs e)
        {
            if (story.Text == "Аккуратно пройдя через салон, но всё же задев ноги всех пассажиров, ты подходишь к туалету. 'Занято!',- ответили тебе на попытку открыть дверь.")
            {
                story.Text = "Вы благополучно долетели до пункта своего назначения!";
                choosebutton1.Visible = false;
                choosebutton2.Visible = false;
                choosebutton3.Visible = false;
                Restart.Visible = true;
            }
            if (story.Text == "Калькулятор? Ну хорошо. Выбери 'уровень'.")
            {
                story.Text = "О нет! Ты поделил на ноль! Вселенная сколлапсировала сама в себя.";
                choosebutton1.Visible = false;
                choosebutton2.Visible = false;
                choosebutton3.Visible = false;
                Restart.Visible = true;
            }
            if (story.Text == "Ты просыпаешься в самолетном кресле.За окном белые,как пена,облака.Рядом с тобой храпит какой-то толстяк,его нога уперлась в твою ногу.")
            {
                story.Text = "Ты легонько хлопаешь толстяка по плечу. Издав последний громкий храп, он проснулся. 'Слышь,чего тебе?'";
                choosebutton1.Text = "Простите пожалуйста, не могли бы вы подвинуть свою ногу?";
                choosebutton2.Text = "Я хотел у вас кое-что спросить";
                choosebutton3.Text = "ТЫ ГРОМКО ХРАПИШЬ И МЕШАЕШЬ МНЕ СВОЕЙ НОГОЙ!";
            }
            if (story.Text == "Ты победил! Может теперь в настоящую игру поиграем?")
            {
                story.Text = "Ты просыпаешься в самолетном кресле.За окном белые,как пена,облака.Рядом с тобой храпит какой-то толстяк,его нога уперлась в твою ногу.";
                choosebutton1.Text = "Аккуратно подвинуть ногу";
                choosebutton2.Text = "Разбудить толстяка";
                choosebutton3.Text = "Разбудить толстяка криком";
            }
            if (story.Text == "Во что будем играть?")
            {
                story.Text = "Калькулятор? Ну хорошо. Выбери 'уровень'.";
                choosebutton1.Text = "2+2";
                choosebutton2.Text = "999:0";
                choosebutton3.Text = "6*9";
            }
            if (story.Text == "Ты немножко поел, после чего случилось то, что часто происходит с людьми в самолете: тебе стало скучно.")
            {
                story.Text = "Во что будем играть?";
                choosebutton1.Text = "Гонки";
                choosebutton2.Text = "Калькулятор";
                choosebutton3.Text = "Невозможный квест";
            }
            if (story.Text == "'А не прилипнет потом у вас кое-что к креслу? Давайте скромнее выбирайте'")
            {
                story.Text = "Ты немножко поел, после чего случилось то, что часто происходит с людьми в самолете: тебе стало скучно.";
                choosebutton1.Text = "Сходить в туалет";
                choosebutton2.Text = "Поиграть на ноутбуке";
                choosebutton3.Text = "Поспать";
            }
            if (story.Text == "Через некоторое время к тебе подошла стюардесса. 'Сегодня на ужин у нас выбор мясо или рыба. Что желаете?")
            {
                story.Text = "Ты немножко поел, после чего случилось то, что часто происходит с людьми в самолете: тебе стало скучно.";
                choosebutton1.Text = "Сходить в туалет";
                choosebutton2.Text = "Поиграть на ноутбуке";
                choosebutton3.Text = "Поспать";
            }
            if (story.Text == "'No more.' Толстяк дал тебе пять и опять уснул")
            {
                story.Text = "Через некоторое время к тебе подошла стюардесса. 'Сегодня на ужин у нас выбор мясо или рыба. Что желаете?";
                choosebutton1.Text = "Мясо";
                choosebutton2.Text = "Рыбу";
                choosebutton3.Text = "Хочу пирожное, хочу мороженое!";
            }
            if (story.Text == "'No more.' Толстяк дал тебе пять и опять уснул")
            {
                story.Text = "Через некоторое время к тебе подошла стюардесса. 'Сегодня на ужин у нас выбор мясо или рыба. Что желаете?";
                choosebutton1.Text = "Мясо";
                choosebutton2.Text = "Рыбу";
                choosebutton3.Text = "Хочу пирожное, хочу мороженое!";
            }
            if (story.Text == "'Baby don't hurt me',- пропел он в ответ.")
            {
                story.Text = "'No more.' Толстяк дал тебе пять и опять уснул";
                choosebutton1.Text = "Толстяк ваще зачетный";
                choosebutton2.Text = "Спокойно сидеть в кресле";
                choosebutton3.Text = "Почитать брошюрку об аварийной посадке";
            }
            if (story.Text == "'Милейший, нет никакой нужды так выражаться, вам впредь стоит выбирать выражения. Ваше общество угнетает меня, пожалуй я пересяду',-сказал толстяк и ушёл.")
            {
                story.Text = "Через некоторое время к тебе подошла стюардесса. 'Сегодня на ужин у нас выбор мясо или рыба. Что желаете?";
                choosebutton1.Text = "Мясо";
                choosebutton2.Text = "Рыбу";
                choosebutton3.Text = "Хочу пирожное, хочу мороженое!";
            }
            if (story.Text == "Его нога похожа на маленького кита, просто так ее не сдвинутью.")
            {
                story.Text = "Ты легонько хлопаешь толстяка по плечу. Издав последний громкий храп, он проснулся. 'Слышь,чего тебе?'";
                choosebutton1.Text = "Простите пожалуйста, не могли бы вы подвинуть свою ногу?";
                choosebutton2.Text = "Я хотел у вас кое-что спросить";
                choosebutton3.Text = "ТЫ ГРОМКО ХРАПИШЬ И МЕШАЕШЬ МНЕ СВОЕЙ НОГОЙ!";
            }
            if (story.Text == "'Чувак, вернись на место, лучше не шути с Чаком.'")
            {
                story.Text = "Дверь туалета открылась и за ней оказался Чак Норрис. Сломав половину самолета, он размахнулся ногой и ударил тебя так сильно, что ты распался на атомы.";
                choosebutton1.Visible = false;
                choosebutton2.Visible = false;
                choosebutton3.Visible = false;
                Restart.Visible = true;
            }
            if (story.Text == "'Ой, великодушный, крайне извиняюсь',- сказал он, после чего отодвинул ногу и вновь уснул. Ну вот, а так хотелось конфликта.")
            {
                story.Text = "Через некоторое время к тебе подошла стюардесса. 'Сегодня на ужин у нас выбор мясо или рыба. Что желаете?";
                choosebutton1.Text = "Мясо";
                choosebutton2.Text = "Рыбу";
                choosebutton3.Text = "Хочу пирожное, хочу мороженое!";
            }
            if (story.Text == "Что будем спрашивать?")
            {
                story.Text = "'О нет, как ты узнал, что я слон под маскировкой? Теперь мне придется тебя съесть', грозно ответил толстяк, а после проглотил тебя.";
                choosebutton1.Visible = false;
                choosebutton2.Visible = false;
                choosebutton3.Visible = false;
                Restart.Visible = true;
            }
            if (story.Text == "Ты легонько хлопаешь толстяка по плечу. Издав последний громкий храп, он проснулся. 'Слышь,чего тебе?'")
            {
                story.Text = "Что будем спрашивать?";
                choosebutton1.Text = "Может подвинешь ногу?";
                choosebutton2.Text = "Кто тебя выпустил из слоновьего питомника?";
                choosebutton3.Text = "What is love?";
            }
            if (story.Text == "Ты незаметно пробрался к аварийной двери, а после рывком открыл её. Сильный поток воздуха вышвыривает тебя за борт. Молодец, ты добился своейго.")
            {
                story.Text = "Ты разбился насмерть. Как так получилось, даже не знаю.";
                choosebutton1.Visible = false;
                choosebutton2.Visible = false;
                choosebutton3.Visible = false;
                Restart.Visible = true;
            }
        }

        private void choosebutton3_Click(object sender, EventArgs e)
        {
            if (story.Text == "Ты немножко поел, после чего случилось то, что часто происходит с людьми в самолете: тебе стало скучно.")
            {
                story.Text = "Вы благополучно долетели до пункта своего назначения!";
                choosebutton1.Visible = false;
                choosebutton2.Visible = false;
                choosebutton3.Visible = false;
                Restart.Visible = true;
            }
            if (story.Text == "Калькулятор? Ну хорошо. Выбери 'уровень'.")
            {
                story.Text = "Ты победил! Может теперь в настоящую игру поиграем?";
                choosebutton1.Text = "Гонки";
                choosebutton3.Text = "Нет, лучше посплю";
                choosebutton2.Text = "Невозможный квест";
            }
            if (story.Text == "'А не прилипнет потом у вас кое-что к креслу? Давайте скромнее выбирайте'")
            {
                story.Text = "Ты немножко поел, после чего случилось то, что часто происходит с людьми в самолете: тебе стало скучно.";
                choosebutton1.Text = "Сходить в туалет";
                choosebutton2.Text = "Поиграть на ноутбуке";
                choosebutton3.Text = "Поспать";
            }
            if (story.Text == "Через некоторое время к тебе подошла стюардесса. 'Сегодня на ужин у нас выбор мясо или рыба. Что желаете?")
            {
                story.Text = "'А не прилипнет потом у вас кое-что к креслу? Давайте скромнее выбирайте'";
                choosebutton1.Text = "Мясо";
                choosebutton2.Text = "Рыбу";
                choosebutton3.Text = "Хлеб с маслом";
            }
            if (story.Text == "'No more.' Толстяк дал тебе пять и опять уснул")
            {
                story.Text = "Через некоторое время к тебе подошла стюардесса. 'Сегодня на ужин у нас выбор мясо или рыба. Что желаете?";
                choosebutton1.Text = "Мясо";
                choosebutton2.Text = "Рыбу";
                choosebutton3.Text = "Хочу пирожное, хочу мороженое!";
            }
            if (story.Text == "'Baby don't hurt me',- пропел он в ответ.")
            {
                story.Text = "'No more.' Толстяк дал тебе пять и опять уснул";
                choosebutton1.Text = "Толстяк ваще зачетный";
                choosebutton2.Text = "Спокойно сидеть в кресле";
                choosebutton3.Text = "Почитать брошюрку об аварийной посадке";
            }
            if (story.Text == "Что будем спрашивать?")
            {
                story.Text = "'Baby don't hurt me',- пропел он в ответ.";
                choosebutton1.Text = "Don't hurt me";
                choosebutton2.Text = "Don't hurt me";
                choosebutton3.Text = "Don't hurt me";
            }
            if (story.Text == "'Милейший, нет никакой нужды так выражаться, вам впредь стоит выбирать выражения. Ваше общество угнетает меня, пожалуй я пересяду',-сказал толстяк и ушёл.")
            {
                story.Text = "Через некоторое время к тебе подошла стюардесса. 'Сегодня на ужин у нас выбор мясо или рыба. Что желаете?";
                choosebutton1.Text = "Мясо";
                choosebutton2.Text = "Рыбу";
                choosebutton3.Text = "Хочу пирожное, хочу мороженое!";
            }
            if (story.Text == "Его нога похожа на маленького кита, просто так ее не сдвинутью.")
            {
                story.Text = "'Милейший, нет никакой нужды так выражаться, вам впредь стоит выбирать выражения. Ваше общество угнетает меня, пожалуй я пересяду',-сказал толстяк и ушёл.";
                choosebutton1.Text = "Да, иди куда подальше!";
                choosebutton2.Text = "Не опрокинь самолет по дороге!";
                choosebutton3.Text = "Стыдливо промолчать";
            }
            if (story.Text == "Ты легонько хлопаешь толстяка по плечу. Издав последний громкий храп, он проснулся. 'Слышь,чего тебе?'")
            {
                story.Text = "'Милейший, нет никакой нужды так выражаться, вам впредь стоит выбирать выражения. Ваше общество угнетает меня, пожалуй я пересяду',-сказал толстяк и ушёл.";
                choosebutton1.Text = "Да, иди куда подальше!";
                choosebutton2.Text = "Не опрокинь самолет по дороге!";
                choosebutton3.Text = "Стыдливо промолчать";
            }
            if (story.Text == "Ты просыпаешься в самолетном кресле.За окном белые,как пена,облака.Рядом с тобой храпит какой-то толстяк,его нога уперлась в твою ногу.")
            {
                story.Text = "'Милейший, нет никакой нужды так выражаться, вам впредь стоит выбирать выражения. Ваше общество угнетает меня, пожалуй я пересяду',-сказал толстяк и ушёл.";
                choosebutton1.Text = "Да, иди куда подальше!";
                choosebutton2.Text = "Не опрокинь самолет по дороге!";
                choosebutton3.Text = "Стыдливо промолчать";
            }
            if (story.Text == "Во что будем играть?")
            {
                story.Text = "Ты просыпаешься в самолетном кресле.За окном белые,как пена,облака.Рядом с тобой храпит какой-то толстяк,его нога уперлась в твою ногу.";
                choosebutton1.Text = "Аккуратно подвинуть ногу";
                choosebutton2.Text = "Разбудить толстяка";
                choosebutton3.Text = "Разбудить толстяка криком";
            }
            if (story.Text == "Аккуратно пройдя через салон, но всё же задев ноги всех пассажиров, ты подходишь к туалету. 'Занято!',- ответили тебе на попытку открыть дверь.")
            {
                story.Text = "'Чувак, вернись на место, лучше не шути с Чаком.'";
                choosebutton1.Text = "Слышь, давай выходи!";
                choosebutton2.Text = "Вернуться на место и уснуть";
                choosebutton3.Text = "А ну быстро вышел!";
            }
            if (story.Text == "'Чувак, вернись на место, лучше не шути с Чаком.'")
            {
                story.Text = "Дверь туалета открылась и за ней оказался Чак Норрис. Сломав половину самолета, он размахнулся ногой и ударил тебя так сильно, что ты распался на атомы.";
                choosebutton1.Visible = false;
                choosebutton2.Visible = false;
                choosebutton3.Visible = false;
                Restart.Visible = true;
            }
            if (story.Text == "Ты незаметно пробрался к аварийной двери, а после рывком открыл её. Сильный поток воздуха вышвыривает тебя за борт. Молодец, ты добился своейго.")
            {
                story.Text = "Ты разбился насмерть. Как так получилось, даже не знаю.";
                choosebutton1.Visible = false;
                choosebutton2.Visible = false;
                choosebutton3.Visible = false;
                Restart.Visible = true;
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            story.Text = "Ты просыпаешься в самолетном кресле.За окном белые,как пена,облака.Рядом с тобой храпит какой-то толстяк,его нога уперлась в твою ногу.";
            choosebutton1.Text = "Аккуратно подвинуть ногу";
            choosebutton2.Text = "Разбудить толстяка";
            choosebutton3.Text = "Разбудить толстяка криком";
            choosebutton1.Visible = true;
            choosebutton2.Visible = true;
            choosebutton3.Visible = true;
            Restart.Visible = false;
        }
    }
}
