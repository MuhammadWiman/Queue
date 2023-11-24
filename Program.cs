using System;

namespace projectWiman
{
    class Program
    {   
        static int[] Antrian = null;
        static int Tail, Head, tailidx = -1, headidx = -1;
        static void Main(string[] args) {
            int menu = 0;
            do {
                Console.Clear();
                Console.WriteLine("Menu Queue");
                Console.WriteLine("1. Buat Antrian");
                Console.WriteLine("2. IsEmpty");
                Console.WriteLine("3. Tampilan Element enQueue");
                Console.WriteLine("4. Tampilan Elememt deQueue");
                Console.WriteLine("0. Keluar");
                Console.Write("\nPiih menu:");
                menu = int.Parse(Console.ReadKey().KeyChar.ToString());
                Console.Clear();
                switch (menu) {
                    case 1 :
                        Console.WriteLine("Membuat Antrian");
                        createAntrian(); 
                        Console.ReadKey();
                        break;
                    case 2 :
                        Console.WriteLine("Apakah Antrian kosong ?");
                        if(!ISEMPTY(Antrian)){
                            Console.WriteLine("Ada Antrian");
                            Console.WriteLine("Antrian :" + Antrian.Length);
                        }
                        else {
                            Console.WriteLine("Antrian Kosong");
                        }
                        Console.ReadKey();
                        break;
                    case 3 :
                        Console.WriteLine("Menu Tampilan Element enQueue :");
                        enQueue(10);
                        enQueue(12);
                        enQueue(14);
                        enQueue(16);
                        enQueue(18);
                        enQueue(20);
                        enQueue(22);
                        enQueue(24);
                        tampilElement();
                        Console.ReadKey();
                        break;
                    case 4 :
                        Console.WriteLine("Menu Tampilan Element deQueue :");
                        deQueue();
                        tampilElement();
                        if (Antrian[0] == 0){
                            Antrian = null;
                        }
                        Console.ReadKey();
                        break;
                }
            } while (menu != 0);
        }
        static void createAntrian()
        {  
            Antrian = new int[8];
            Tail = 0; Head = 0;
        }
        static void enQueue (int element) {
            Antrian[tailidx + 1] = element ;
            tailidx ++ ;
            headidx = 0 ;
            Tail = element; Head = Antrian[headidx];
        }
        static void deQueue () {
            int[] bufferQ = new int[8];
            int y = -1;
            for(int i = 1; i < Antrian.Length; i++){
                y = y + 1;
                bufferQ[y] = Antrian[i];
            }
            Antrian = bufferQ;
            tailidx = y;
            Tail = Antrian[headidx];
            Head= Antrian[tailidx];
        }
        static bool ISEMPTY(int[] s)
        {
            if (Antrian == null)
                return true;
            else return false;
        }
        static void tampilElement () {
            Console.WriteLine("Antrian : ");
            for(int i = headidx; i <= tailidx; i++) {
                Console.Write(Antrian[i]+" ");
            }
            Console.WriteLine();
        }
    }
}