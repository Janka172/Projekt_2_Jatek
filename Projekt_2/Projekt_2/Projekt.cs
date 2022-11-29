using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_2
{
    class Projekt
    {
        static void Main(string[] args)
        {
            string mit = "0";
            string akarsz = "i";
            while (akarsz=="i")
            {
                do
                {
                    Console.Write("Mi teszertnél játszani?\n1: Bűnügyi nyomozás\n2:");
                    Console.WriteLine();
                    mit = Console.ReadLine();
                } while (mit!="1" && mit != "2");
                if (mit=="1")
                {
                    Console.WriteLine("\t\t\t\t\t - ! - Bűnügyi nyomozás - ! -\n\t - ! - Egy fő háttértörtének és az abban szereplő emberek elmondásai alapján kell megfejtened egy bűnügyi esetet! - ! - \n - !- Jól gondold át a válaszodat a döntésed, hiszen csak egy lehetőséged van elkapni az elkövetőt! - ! - \nEgy szombat hajnali egy óra felé egy férfit a hálószobájában találnak holtan, mellkason szúrva. A házban a felesége, a kertész és egy szakács tartózkodott az eset ideje alatt. A feleség hívta ki a rendőrséget szombaton, reggel, fél tizenegy órakor. A nyomozó, nem mondott el senkinek semmi részletet vagy körülményt a gyilkossággal kapcsolatban, azonnal a potenciális elkövetők alibijére volt kíváncsi:\n\tFeleség: Állítása szerint a férjét az előző esti vacsoránál látta utoljára, ami után átment a lányukhoz és ott aludt, aki két utcával odébb lakott, de a férje nem tartott vele, mert már nagyon fáradt volt. A kertésszel találkozott indulás előtt, éppen a sövényt nyírta formára. Este fél tizenkettő után három perccel még felhívta a szakácsot, hogy szóljon neki arról hogy késik a reggeliről. Ezért ért haza fél tizenegy órakor, amikor is rátalált a férje holt testére.\n\tA feleség alibijét hallva a nyomozó felvette az özvegy lányának a vallomását is. \n\tA lány biztosan állította, hogy az anyja előző éjszakán náluk aludt. Beszámolt arról is, hogy mielőtt az anyja odaért volna, felhívta az apját aki elmondta neki, hogy fáradtsága miatt inkább otthon marad. A lány sajnálta, de nem erősködött, mert tudta, hogy apja akkoriban sokat gyengélkedett. Másnap az anyja hívta fel dél előtt tíz perccel, hogy elmondja neki a halálhírt.\n\tKerész: Állítása szerint este lenyírta a sövényt, miközben találkozott a feleséggel, aki egyedül hagyta el a ház területét, de utána nem látta aznap, csak másnap mikor dolgozni indult és akkorra már a feleség a rendőrséggel együtt fogadta. Még este bepakolt a fészerbe és indulása előtt lement a konyhába, ez éjfélkor történt, senki nem volt a konyhában a csap tele volt a elmosatlan edényekkel, látszólag minden rendben volt, egy valamit kivéve egy fiókot. A fiók ki volt húzva, hiányzott belőle egy kés, ami azért volt feltűnő hiszen a tokja üresen hevert. Kifelé menet látta a szakácsot a nappaliban nézte a tv-t, elköszönt tőle, de a szakács csak ránézett és nevetett. A kertész szerint a szakács gyakran viselkedett furcsán, de azt gondolta biztos ivott megint valamit. \n\tSzakács: Állítása szerint a vacsora után elmosogatott, és mivel már nem volt dolga éjfélkor hazament, nem találkozott senkivel, másnap akkor ért a házhoz mikor a feleség felhívta azzal, hogy a nyomozó beszélni szeretne vele. Első reakciója az volt, hogy rákérdezzen arra, hogy megtalálták-e azt a kést amivel a gyilkosságot elkövették.");
                    string kiaz = "0";
                    do
                    {
                        Console.Write("Ki lehetett a gyilkos? \n1: A feleség\n2: A szakács\n3: A kertész\n");
                        kiaz = Console.ReadLine();
                    } while (kiaz!="1" && kiaz != "2" && kiaz != "3");
                    if (kiaz=="2")
                    {
                        Console.WriteLine("Eltaláltad a helyes választ!");
                        Console.WriteLine("A gyilkos a szakács volt. Ez abból állapítható meg, hogy nem említette, hogy a feleség felhívta volna, illetve azt állította, hogy nem találkozott senkivel, pedig a kertész állította, hogy látta a nappaliban tv-t nézni. A kertész alibijét pedig alátámasztotta a feleség, akit a saját lánya igazolt. Azt állította, hogy elmosogatott, pedig az edények mosatlanul álltak a konyhában. A legszembetűnőbb az, hogy a nyomozó nem mondta el, hogy a bűncselekményt egy késsel követték el, de a szakács egyből a késről érdeklődött.");
                    }
                    else
                    {
                        Console.WriteLine("A válasz helytelen!");
                        Console.WriteLine("A gyilkos a szakács volt. Ez abból állapítható meg, hogy nem említette, hogy a feleség felhívta volna, illetve azt állította, hogy nem találkozott senkivel, pedig a kertész állította, hogy látta a nappaliban tv-t nézni. A kertész alibijét pedig alátámasztotta a feleség, akit a saját lánya igazolt. Azt állította, hogy elmosogatott, pedig az edények mosatlanul álltak a konyhában. A legszembetűnőbb az, hogy a nyomozó nem mondta el, hogy a bűncselekményt egy késsel követték el, de a szakács egyből a késről érdeklődött.");
                    }
                

                }
                do
                {
                    Console.Write("Akarsz még játszani? [i/n]");
                    akarsz = Console.ReadLine();
                } while (akarsz!="i" && akarsz!="n");
                
            }





            Console.ReadKey();
        }
    }
}
