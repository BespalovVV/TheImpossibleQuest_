﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheImpossibleQuestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string r1 = "Ты просыпаешься в самолётном кресле,\n" +
           " рядом с тобой спит какой-то толстяк,\n" +
           " его нога упёрлась в твою ногу.";
            Console.WriteLine(r1);
            bool check = true;
            string b1 = "Аккуратно подвинуть ногу";
            string b2 = "Разбудить толстяка";
            string b3 = "Разбудить толстяка матом";
            string res = "";
            while (check == true)
            {
                
                Console.WriteLine("\n 1-" + b1 + "\n 2-" + b2 + "\n 3-" + b3);
                Console.WriteLine("_._._._._._._._._._._._._._._._._._._");
                res += Console.ReadLine();
                if (res == "1")
                {
                    Console.WriteLine("Его нога похожа на маленького кита, просто так её не сдвинуть.");
                    b1 = "Терпеть неудобство как лох";
                }
                if ((res == "2") || (res == "12"))
                {
                    Console.WriteLine("Ты легонько хлопаешь толстяка по плечу. \nИздав последний громкий храп, он проснулся. 'Слышь, чего тебе?'");
                    b1 = "Простите пожалуйста, не могли бы вы подвинуть свою ногу?";
                    b2 = "Я хотел у вас кое-что спросить";
                    b3 = "ТЫ ГРОМКО ХРАПИШЬ И МЕШАЕШЬ МНЕ СВОЕЙ НОГОЙ";
                }
                if ((res == "3")||(res == "13")||(res =="23")||(res =="123"))
                {
                    Console.WriteLine("'Милейший, нет никакой нужды так выражаться, вам впредь стоит выбирать выражения. Ваше общество меня угнетает, пожалуй я пересяду.' - Сказал он и ушёл.");
                    b1 = "Да, иди куда подальше!";
                    b2 = "Не опрокинь самолёт по дороге!";
                    b3 = "Стыдливо промолчать";
                }
                if ((res == "11")||(res == "12113")||(res == "2113")||(res =="231")||(res =="1231")||(res =="232")||(res=="1232")||(res=="212")||(res=="1212")||(res=="122113")||(res=="22113")||(res =="1233")||(res=="233")||(res=="213")||(res=="1213")||(res =="12213")||(res=="2213")||(res=="31")||(res=="32")||(res=="33")||(res=="131")||(res=="132")||(res=="133"))
                {
                    Console.WriteLine("Через некоторое время к тебе подошла стюардесса. 'Сегодня на ужин у нас на выбор мясо или рыба. что желаете?'");
                    b1 = "Мясо";
                    b2 = "Рыба";
                    b3 = "Хочу пироженое, хочу мороженое!";
                    res = "4.";
                }
                if ((res == "21")||(res == "121")||(res =="221")||(res == "1221"))
                {
                    Console.WriteLine("'Ой, великодушный, крайне извиняюсь', сказал он, после чего отодвинул ногу и вновь уснул. Ну вот, а так хотелось конфликта.");
                    b1 = "Устроить конфликт";
                    b2 = "Спокойно сидеть в кресле";
                    b3 = "почитать брошурку об аварийной посадке";
                }
                if ((res == "1211") || (res=="211")||(res == "12211")||(res == "2211"))
                {
                    Console.WriteLine("Ну и какую глупость ты хочешь устроить?");
                    b1 = "Прыгнуть с самолёта";
                    b2 = "Наорать на толстяка";
                    b3 = "Перестать хотеть устроить конфликт";
                }
                if ((res == "12111") || (res == "2111")||(res == "122111")||(res == "22111"))
                {
                    Console.WriteLine("Ты незаметно пробрался к аварийной двери, а после рывком открыл её. Сильный поток ветра вышвыривает тебя за борт. Молодец, ты добился своего.");
                    b1 = "прыгать солдатиком";
                    b2 = "прыгать бомбочкой";
                    b3 = "подумать о выгодности своих действий";
                }
                if ((res == "121113")||(res == "21113")||(res == "21111")||(res == "21112")||(res == "121112")||(res == "121111"))
                {
                    Console.WriteLine("ты разбился насмерть. Как так получилось, даже не знаю.\n");
                    check = false;
                    res = "";
                    check = true;
                    b1 = "Аккуратно подвинуть ногу";
                    b2 = "Разбудить толстяка";
                    b3 = "Разбудить толстяка матом";
                    Console.WriteLine("_._._._._._._._._._._._._._._._._._._");
                    Console.WriteLine(r1);
                }
                if ((res == "22") || (res == "122"))
                {
                    Console.WriteLine("Что будем спрашивать?");
                    b1 = "Может подвинешь ногу?";
                    b2 = "Кто тебя выпустил из слоновьего питомника?";
                    b3 = "What is love?";
                }
                if ((res=="222") || (res=="1222"))
                {
                    Console.WriteLine("О нет, как ты узнал, что я слон под маскировкой? 'Теперь мне придётся тебя сьесть.'-Грозно ответил толстяк, а после проглотил тебя.");
                    check = false;
                    res = "";
                    check = true;
                    b1 = "Аккуратно подвинуть ногу";
                    b2 = "Разбудить толстяка";
                    b3 = "Разбудить толстяка матом";
                    Console.WriteLine("_._._._._._._._._._._._._._._._._._._");
                    Console.WriteLine(r1);
                }
                if ((res=="223")||(res=="1223"))
                {
                    Console.WriteLine("'Baby don't hurt me'- Пропел он в ответ");
                    b1 = "don't hurt me";
                    b2 = "don't hurt me";
                    b3 = "don't hurt me";
                }
                if ((res == "2231") || (res == "12231")|| (res == "2232") || (res == "12232")|| (res == "2233") || (res == "12233"))
                {
                    Console.WriteLine("'No more...' Толстяк дал тебе пять и опять уснул.");
                    b1 = "Толстяк ваще зачётный";
                    b2 = "Спокойно сидеть в кресле";
                    b3 = "Почитать брошурку об аварийной посадке";
                    res = "23";
                }
                if (res == "4.3")
                {
                    Console.WriteLine("'А не прилипнет ли у вас потом кое-что к креслу? Давайте скромнее выбрайте'");
                    b3 = "Хлеб с маслом";
                }
                if ((res=="4.31")||(res=="4.32")||(res=="4.33")||(res=="4.1")||(res=="4.2"))
                {
                    Console.WriteLine("Ты немного поел, после чего случилось то, что часто происходит с людьми в самолёте: тебе стало скучно.");
                    b1 = "Сходить в туалет";
                    b2 = "Поиграть на ноутбуке";
                    b3 = "Поспать";
                }
                if ((res == "4.311") || (res == "4.321") || (res == "4.331") || (res == "4.11") || (res == "4.21"))
                {
                    Console.WriteLine("'Занято!'- ответили тебе на попытку открыть дверь.");
                    b1 = "Слышь, давай выходи!";
                    b2 = "Вернуться на место и уснуть";
                    b3 = "А ну быстро вышел!";
                }
                if ((res == "4.3111") || (res == "4.3211") || (res == "4.3311") || (res == "4.111") || (res == "4.211")||(res == "4.3113") || (res == "4.3213") || (res == "4.3313") || (res == "4.113") || (res == "4.213"))
                {
                    Console.WriteLine("'Чувак, вернись на место. Лучше не шути с чаком.'");
                    b1 = "Вернуться на место и уснуть.";
                    b2 = "Да мне пофиг кто ты, вышел я сказал!";
                    b3 = "Хаха, Чак - дебильное имя!";
                }
                if ((res == "4.31112") || (res == "4.32112") || (res == "4.33112") || (res == "4.1112") || (res == "4.2112") || (res == "4.31132") || (res == "4.32132") || (res == "4.33132") || (res == "4.1132") || (res == "4.2132")|| (res == "4.31113") || (res == "4.32113") || (res == "4.33113") || (res == "4.1113") || (res == "4.2113") || (res == "4.31133") || (res == "4.32133") || (res == "4.33133") || (res == "4.1133") || (res == "4.2133"))
                {
                    Console.WriteLine("Дверь туалета открылась и за ней оказался Чак Норрис. Сломав половину самолёта, он размахнулся ногой и ударил тебя так сильно, что ты расщепился на атомы");
                    check = false;
                    res = "";
                    check = true;
                    b1 = "Аккуратно подвинуть ногу";
                    b2 = "Разбудить толстяка";
                    b3 = "Разбудить толстяка матом";
                    Console.WriteLine("_._._._._._._._._._._._._._._._._._._");
                    Console.WriteLine(r1);
                }
                if ((res == "4.312") || (res == "4.322") || (res == "4.332") || (res == "4.12") || (res == "4.22"))
                {
                    Console.WriteLine("Во что будем играть?");
                    b1 = "Калькулятор";
                    b2 = "Невозможный квест";
                    b3 = "";
                }
                if ((res == "4.3121") || (res == "4.3221") || (res == "4.3321") || (res == "4.121") || (res == "4.221"))
                {
                    Console.WriteLine("Выберите уровень");
                    b1 = "2+2";
                    b2 = "9x6";
                    b3 = "999:0";
                }
                if ((res == "4.31213") || (res == "4.32213") || (res == "4.33213") || (res == "4.1213") || (res == "4.2213"))
                {
                    Console.WriteLine("О нет! Ты поделил на ноль, вселенная сколлапсировала сама в себя.");
                    check = false;
                    res = "";
                    check = true;
                    b1 = "Аккуратно подвинуть ногу";
                    b2 = "Разбудить толстяка";
                    b3 = "Разбудить толстяка матом";
                    Console.WriteLine("_._._._._._._._._._._._._._._._._._._");
                    Console.WriteLine(r1);
                }
                if ((res == "4.31211") || (res == "4.32211") || (res == "4.33211") || (res == "4.1211") || (res == "4.2211")|| (res == "4.31212") || (res == "4.32212") || (res == "4.33212") || (res == "4.1212") || (res == "4.2212"))
                {
                    Console.WriteLine("Ты победил!");
                    b1 = "Спать";
                    b2 = "Спать";
                    b3 = "Спать";
                    
                }
                if ((res == "4.31111") || (res == "4.32111") || (res == "4.33111") || (res == "4.1111") || (res == "4.2111") || (res == "4.3113") || (res == "4.3213") || (res == "4.3313") || (res == "4.113") || (res == "4.213")||(res == "4.313") || (res == "4.323") || (res == "4.333") || (res == "4.13") || (res == "4.23") || (res == "4.3112") || (res == "4.3212") || (res == "4.3312") || (res == "4.112") || (res == "4.212") || (res == "4.312111") || (res == "4.322111") || (res == "4.332111") || (res == "4.12111") || (res == "4.22111") || (res == "4.312121") || (res == "4.322121") || (res == "4.332121") || (res == "4.12121") || (res == "4.22121")|| (res == "4.312112") || (res == "4.322112") || (res == "4.332112") || (res == "4.12112") || (res == "4.22112") || (res == "4.312122") || (res == "4.322122") || (res == "4.332122") || (res == "4.12122") || (res == "4.22122")|| (res == "4.312113") || (res == "4.322113") || (res == "4.332113") || (res == "4.12113") || (res == "4.22113") || (res == "4.312123") || (res == "4.322123") || (res == "4.332123") || (res == "4.12123") || (res == "4.22123"))
                {
                    Console.WriteLine("Ты проснулся от голоса стюардессы в динамиках:'Товарищи пассажиры, не хочу никого пугать, но рыба, которую давали на ужин, отравлена'");
                    b1 = "ПАНИКАПАНИКАПАНИКА";
                    b2 = "ПАНИКАПАНИКАПАНИКА";
                    b3 = "ПАНИКАПАНИКАПАНИКА";
                }
                if ((res == "4.3121111") || (res == "4.3221111") || (res == "4.3321111") || (res == "4.121111") || (res == "4.221111") || (res == "4.3121211") || (res == "4.3221211") || (res == "4.3321211") || (res == "4.121211") || (res == "4.221211") || (res == "4.3121121") || (res == "4.3221121") || (res == "4.3321121") || (res == "4.121121") || (res == "4.221121") || (res == "4.3121221") || (res == "4.3221221") || (res == "4.3321221") || (res == "4.121221") || (res == "4.221221") || (res == "4.3121131") || (res == "4.3221131") || (res == "4.3321131") || (res == "4.121131") || (res == "4.221131") || (res == "4.3121231") || (res == "4.3221231") || (res == "4.3321231") || (res == "4.121231") || (res == "4.221231")||(res == "4.3121112") || (res == "4.3221112") || (res == "4.3321112") || (res == "4.121112") || (res == "4.221112") || (res == "4.3121212") || (res == "4.3221212") || (res == "4.3321212") || (res == "4.121212") || (res == "4.221212") || (res == "4.3121122") || (res == "4.3221122") || (res == "4.3321122") || (res == "4.121122") || (res == "4.221122") || (res == "4.3121222") || (res == "4.3221222") || (res == "4.3321222") || (res == "4.121222") || (res == "4.221222") || (res == "4.3121132") || (res == "4.3221132") || (res == "4.3321132") || (res == "4.121132") || (res == "4.221132") || (res == "4.3121232") || (res == "4.3221232") || (res == "4.3321232") || (res == "4.121232") || (res == "4.221232")||(res == "4.3121113") || (res == "4.3221113") || (res == "4.3321113") || (res == "4.121113") || (res == "4.221113") || (res == "4.3121213") || (res == "4.3221213") || (res == "4.3321213") || (res == "4.121213") || (res == "4.221213") || (res == "4.3121123") || (res == "4.3221123") || (res == "4.3321123") || (res == "4.121123") || (res == "4.221123") || (res == "4.3121223") || (res == "4.3221223") || (res == "4.3321223") || (res == "4.121223") || (res == "4.221223") || (res == "4.3121133") || (res == "4.3221133") || (res == "4.3321133") || (res == "4.121133") || (res == "4.221133") || (res == "4.3121233") || (res == "4.3221233") || (res == "4.3321233") || (res == "4.121233") || (res == "4.221233"))
                {
                    Console.WriteLine("Вы успешно долетели!");
                    check = false;
                    res = "";
                    check = true;
                    b1 = "Аккуратно подвинуть ногу";
                    b2 = "Разбудить толстяка";
                    b3 = "Разбудить толстяка матом";
                    Console.WriteLine("_._._._._._._._._._._._._._._._._._._");
                    Console.WriteLine(r1);
                }
                if ((res== "4.321111") ||(res== "4.21111") || (res == "4.321311") || (res == "4.21311") || (res == "4.3231") || (res == "4.231") || (res == "4.32121") || (res == "4.2121") || (res == "4.3221111") || (res == "4.221111") || (res == "4.3221211") || (res == "4.221211") || (res == "4.3221121") || (res == "4.221121") || (res == "4.3221221") || (res == "4.221221") || (res == "4.3221131") || (res == "4.221131") || (res == "4.3221231") || (res == "4.221231")||(res == "4.321112") || (res == "4.21112") || (res == "4.321312") || (res == "4.21312") || (res == "4.3232") || (res == "4.232") || (res == "4.32122") || (res == "4.2122") || (res == "4.3221112") || (res == "4.221112") || (res == "4.3221212") || (res == "4.221212") || (res == "4.3221122") || (res == "4.221122") || (res == "4.3221222") || (res == "4.221222") || (res == "4.3221132") || (res == "4.221132") || (res == "4.3221232") || (res == "4.221232")||(res == "4.321113") || (res == "4.21113") || (res == "4.321313") || (res == "4.21313") || (res == "4.3233") || (res == "4.233") || (res == "4.32123") || (res == "4.2123") || (res == "4.3221113") || (res == "4.221113") || (res == "4.3221213") || (res == "4.221213") || (res == "4.3221123") || (res == "4.221123") || (res == "4.3221223") || (res == "4.221223") || (res == "4.3221133") || (res == "4.221133") || (res == "4.3221233") || (res == "4.221233"))
                {
                    Console.WriteLine("Вокруг поднялась дикая паника. Половина пассажиров слегла с сильными судорогами, а потом и вовсе умерла, в том числе и вы.");
                    check = false;
                    res = "";
                    check = true;
                    b1 = "Аккуратно подвинуть ногу";
                    b2 = "Разбудить толстяка";
                    b3 = "Разбудить толстяка матом";
                    Console.WriteLine("_._._._._._._._._._._._._._._._._._._");
                    Console.WriteLine(r1);
                }
            }
        }
    }
}
