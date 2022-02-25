using System;

namespace Kelompok3
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilihMenu = 0;
            ControllerUser controller = new ControllerUser(); // buat objek controller
            View view = new View(); // buat objek view

            bool appRun = true;
            while (appRun == true)
            {
                Console.Clear();
                view.MenuUtama(); // tampilkan menu
                Console.Write($"  Masukkan Menu : ");
                try
                {
                    pilihMenu = int.Parse(Console.ReadLine()); // input pilihan menu
                }
                catch
                {
                    Console.WriteLine(" Terjadi Error");
                }
                switch (pilihMenu)
                {
                    case 1:
                        bool sedangCreateUser = true;
                        while (sedangCreateUser == true)
                        {
                            view.CreateUser(); // panggil tampilan untuk create user
                            Console.Write($"  Ingin Membuat User Lagi? (y/n) : "); char jawabanCreateUser = char.Parse(Console.ReadLine());
                            if (jawabanCreateUser == 'y')
                            {
                                Console.Clear();
                            }
                            else
                            {
                                sedangCreateUser = false;
                                Console.Clear();
                            }
                        }
                        break;
                    case 2:
                        bool sedangShowUsers = true;
                        while (sedangShowUsers == true)
                        {
                            view.ShowUser(); // tampilkan data user
                            Console.Write($"  Kembali? (y/n) : "); char jawabanKembali = char.Parse(Console.ReadLine());
                            if (jawabanKembali == 'y')
                            {
                                sedangShowUsers = false;
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();
                            }
                        }
                        break;
                    case 3:
                        bool sedangSearch = true;
                        while (sedangSearch == true)
                        {
                            view.SearchUser();
                            Console.Write($" Apakah ingin search lagi? (y/n) : "); char jawabanSearch = char.Parse(Console.ReadLine());
                            if (jawabanSearch == 'n')
                            {
                                sedangSearch = false;
                            }
                            Console.Clear();
                        }
                        break;
                    case 4:
                        bool sedangLogin = true;
                        while (sedangLogin == true)
                        {
                            view.Login();
                            Console.Write($"  Kembali? (y/n) : "); char jawabanKembali = char.Parse(Console.ReadLine());
                            if (jawabanKembali == 'y')
                            {
                                sedangLogin = false;
                            }
                            Console.Clear();
                        }
                        break;
                    case 5:
                        bool sedangUpdate = true;
                        while (sedangUpdate == true)
                        {
                            view.UpdateUser();
                            Console.Write($"  Apakah Ingin Update User Lagi? (y/n) : "); char jawabanUpdate = char.Parse(Console.ReadLine());
                            if (jawabanUpdate == 'n')
                            {
                                sedangUpdate = false;
                            }
                            Console.Clear();
                        }
                        break;
                    case 6:
                        bool sedangDelete = true;
                        while (sedangDelete == true)
                        {
                            view.Delete(); // panggil view deleteuser
                            Console.Write($" Apakah ingin menghapus lagi? (y/n) : "); char jawabanDelete = char.Parse(Console.ReadLine());
                            if (jawabanDelete == 'n')
                            {
                                sedangDelete = false;
                            }
                            Console.Clear();
                        }
                        break;
                    case 7:
                        Console.Write($"  Apakah Ingin Keluar? (y/n) : "); char jawabanExit = char.Parse(Console.ReadLine());
                        if (jawabanExit == 'y')
                        {
                            appRun = false;
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                        }
                        break;
                }
            }
        }
    }
}