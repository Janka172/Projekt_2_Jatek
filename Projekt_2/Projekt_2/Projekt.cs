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
            Console.WriteLine("\n\t\t██████╗░██████╗░░█████╗░░░░░░██╗███████╗██╗░░██╗████████╗\n\t\t██╔══██╗██╔══██╗██╔══██╗░░░░░██║██╔════╝██║░██╔╝╚══██╔══╝\n\t\t██████╔╝██████╔╝██║░░██║░░░░░██║█████╗░░█████═╝░░░░██║░░░\n\t\t██╔═══╝░██╔══██╗██║░░██║██╗░░██║██╔══╝░░██╔═██╗░░░░██║░░░\n\t\t██║░░░░░██║░░██║╚█████╔╝╚█████╔╝███████╗██║░╚██╗░░░██║░░░\n\t\t╚═╝░░░░░╚═╝░░╚═╝░╚════╝░░╚════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░");

            string mit = "0";
            string akarsz = "i";
            while (akarsz=="i")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\nMi teszertnél játszani?\n");
                Console.ForegroundColor = ConsoleColor.White;
                do
                {
                    Console.Write("1: Bűnügyi nyomozás\n2: Macska szimulátor\n");
                    Console.WriteLine();
                    mit = Console.ReadLine();
                } while (mit!="1" && mit != "2");
                if (mit=="1")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t\t - ! - Bűnügyi nyomozás - ! -\n\t");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" - ! - Egy fő háttértörtének és az abban szereplő emberek elmondásai alapján kell megfejtened egy bűnügyi esetet! - ! - \n - !- Jól gondold át a válaszodat a döntésed, hiszen csak egy lehetőséged van elkapni az elkövetőt! - ! - \nEgy szombat hajnali egy óra felé egy férfit a hálószobájában találnak holtan, mellkason szúrva. A házban a felesége, a kertész és egy szakács tartózkodott az eset ideje alatt. A feleség hívta ki a rendőrséget szombaton, reggel, fél tizenegy órakor. A nyomozó, nem mondott el senkinek semmi részletet vagy körülményt a gyilkossággal kapcsolatban, azonnal a potenciális elkövetők alibijére volt kíváncsi:\n\tFeleség: Állítása szerint a férjét az előző esti vacsoránál látta utoljára, ami után átment a lányukhoz és ott aludt, aki két utcával odébb lakott, de a férje nem tartott vele, mert már nagyon fáradt volt. A kertésszel találkozott indulás előtt, éppen a sövényt nyírta formára. Este fél tizenkettő után három perccel még felhívta a szakácsot, hogy szóljon neki arról hogy késik a reggeliről. Ezért ért haza fél tizenegy órakor, amikor is rátalált a férje holt testére.\n\tA feleség alibijét hallva a nyomozó felvette az özvegy lányának a vallomását is. \n\tA lány biztosan állította, hogy az anyja előző éjszakán náluk aludt. Beszámolt arról is, hogy mielőtt az anyja odaért volna, felhívta az apját aki elmondta neki, hogy fáradtsága miatt inkább otthon marad. A lány sajnálta, de nem erősködött, mert tudta, hogy apja akkoriban sokat gyengélkedett. Másnap az anyja hívta fel dél előtt tíz perccel, hogy elmondja neki a halálhírt.\n\tKerész: Állítása szerint este lenyírta a sövényt, miközben találkozott a feleséggel, aki egyedül hagyta el a ház területét, de utána nem látta aznap, csak másnap mikor dolgozni indult és akkorra már a feleség a rendőrséggel együtt fogadta. Még este bepakolt a fészerbe és indulása előtt lement a konyhába, ez éjfélkor történt, senki nem volt a konyhában a csap tele volt a elmosatlan edényekkel, látszólag minden rendben volt, egy valamit kivéve egy fiókot. A fiók ki volt húzva, hiányzott belőle egy kés, ami azért volt feltűnő hiszen a tokja üresen hevert. Kifelé menet látta a szakácsot a nappaliban nézte a tv-t, elköszönt tőle, de a szakács csak ránézett és nevetett. A kertész szerint a szakács gyakran viselkedett furcsán, de azt gondolta biztos ivott megint valamit. \n\tSzakács: Állítása szerint a vacsora után elmosogatott, és mivel már nem volt dolga éjfélkor hazament, nem találkozott senkivel, másnap akkor ért a házhoz mikor a feleség felhívta azzal, hogy a nyomozó beszélni szeretne vele. Első reakciója az volt, hogy rákérdezzen arra, hogy megtalálták-e azt a kést amivel a gyilkosságot elkövették.");
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
                if (mit == "2")
                {
                    int meghalsz = 0;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t\t - ! - Macska szimulátor - ! -\n\t");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" - ! - A játék lényege az, hogy te egy macska szerepében tudd minél tovább túlélni.\n\tA játék folyamán a döntésed befolyásolják majd a végkifejletet. \n\tHa választási lehetőség elé kerülsz az általad választott cselekvés számának megadásával tudod végrehajtani azt.- ! -\n        _..---...,''-._     ,/}/)\t--Igaz történet alapján--\n     .''        ,      ``..'(/-< \n    /   _      {      )         |\n   ;   _ `.     `.   <         a(\n ,'   ( |  )      `.  | __.._ .: y\n(  <|_-) )'-.____...|  `._   //-'\n `. `-' /-._)))      `-._)))\n   `...'     \n");
                    //1.nap
                    Console.WriteLine("\n- + - 1. nap - + -");
                    Console.WriteLine("Az új gazdáid hazavittek magukkal egy új kutyát. Így már nem vagy együli háziállat. A kutya csak néhány hónapos, te meg már egy éves múltál, ami azt jeleni hogy előnyösek számodra az erőviszonyok. Az első találkozásotok alkalmával...");
                    Console.WriteLine("1: Megtámadod, ezzel bosszút állva azért mert úgy érzed hogy lecserélnek. \n2: Nem foglalkozol vele, ameddig ő is békén hagy téged nem érdekel.\n3: Elfutsz, mert félsz az ismeretlen állattól. \n\t");
                    string elsonap = "";
                    do
                    {
                        elsonap = Console.ReadLine();
                    } while (elsonap != "1" && elsonap != "2" && elsonap != "3");
                    switch (elsonap)
                    {
                        case "1": meghalsz++; break;
                        case "2": break;
                        default: break;
                    }
                    //2. nap
                    Console.WriteLine("\n- + - 2. nap - + -");
                    if (meghalsz == 1) //2. nap - 1. verzió (1)
                    {
                        Console.WriteLine("Az előző napi incidensed után a gazdáid megharagudtak rád, és az ellenkezőjét érted el annak amit szerettél volna. Este, a szokásos etetési időben kevesebb ételt adtak, azt remélve, hogy a két cselekményt majd összekötöd.\nAznap amikor elmentek dolgozni a kutyát nem láttad sehol, látszólag egyedül voltál a lakásban, egy valami viszon eltért a megszokottól. Az asztalon kint felejtettek egy zacskó kiflit...");
                        Console.WriteLine("1: Felugrasz az asztalra és beleeszel az egyik kiflibe\n2: Felugrasz az asztalra és a bosszútól fűtve beleeszel mindegyikbe\n3: Figyelmen kívül hagyod, mivel nem szeretnél még több bajt\n\t");
                        string masodiknapelsoverzio = "";
                        do
                        {
                            masodiknapelsoverzio = Console.ReadLine();
                        } while (masodiknapelsoverzio != "1" && masodiknapelsoverzio != "2" && masodiknapelsoverzio != "3");
                        switch (masodiknapelsoverzio)
                        {
                            case "1": meghalsz++; break;
                            case "2": meghalsz+=2; break;
                            default: break;
                        }
                    }
                    else //2. nap - 2. verzió (0)
                    {
                        Console.WriteLine("Az előző nap után a gazdáid úgy gondolják, hogy még össze kell szoknotok az új kutyával, ezért őt is beengedik a házba. Te próbálod tartani tőle a távolságot, de ő mindenképpen játszani akar veled. Mivel te vagy az ügyesebb felugrasz egy szekrényre, aminek a tetején nyugodtan tudsz aludni, miközben azt figyeled, hogy a kis szerncsétlen kutya hogyan próbál téged megtalálni.");
                        Console.WriteLine("      ||      _,,,---,,_\nZZZzz /,`.-'`'    -.  ;-;;,_\n     |,4-  ) )-,_. ,| (  `'-'\n    '---''(_/--'  `-'|_)\n");
                        Console.WriteLine("Aludtál három órán keresztül, arra ébredsz, hogy éhes vagy. Körülnézel feltérképezed a környzetet, lemászol a szekrényről, és ahogy a táladhoz érsz, azt veszed észre, hogy üres, és a kutya ott alszik mellette.\nVisszamész a nappaliba, látod, hogy az asztalon van egy zacskó kiflit. Azzal szemben a polcon látsz egy zacskó kutya kaját...");
                        Console.WriteLine("1: Visszafekszel aludni, és majd eszel amikor a gazdáid hazajönnek és megetetnek\n2: Felugrasz a szekrényre és bosszúbol beleeszel a kutya kajájába\n3: Felugrasz az asztalra, és beleeszel az egyik kiflibe\n\t");
                        string masodiknapmasodikverzio = "";
                        do
                        {
                            masodiknapmasodikverzio = Console.ReadLine();
                        } while (masodiknapmasodikverzio != "1" && masodiknapmasodikverzio != "2" && masodiknapmasodikverzio != "3");
                        switch (masodiknapmasodikverzio)
                        {
                            case "1": break;
                            case "2": meghalsz ++; break;
                            default: meghalsz++; break;
                        }
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
