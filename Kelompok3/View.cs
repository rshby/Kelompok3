using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelompok3
{
    class View
    {
        ControllerUser controller = new ControllerUser(); // buat objek controller

        public void MenuUtama()
        {
            Console.Clear();
            Console.WriteLine($" ==========================================");
            Console.WriteLine($" =====     Basic Authentication       =====");
            Console.WriteLine($" ==========================================");
            Console.WriteLine($" 1. Create User");
            Console.WriteLine($" 2. Show User");
            Console.WriteLine($" 3. Search");
            Console.WriteLine($" 4. Login");
            Console.WriteLine($" 5. Update User");
            Console.WriteLine($" 6. Delete User");
            Console.WriteLine($" 7. Exit");
        }
        public void CreateUser()
        {
            Console.Clear();
            Console.WriteLine($" ================================");
            Console.WriteLine($" =====      CREATE USER     =====");
            Console.WriteLine($" ================================");
            Console.Write($" Masukkan FirstName : "); string inputFirstName = Console.ReadLine();
            Console.Write($" Masukkan LastName : "); string inputLastName = Console.ReadLine();
            Console.Write($" Masukkan Password : "); string inputPassword = Console.ReadLine();
            controller.CreateUser(inputFirstName, inputLastName, inputPassword); // pangill controller untuk create user
        }
        public void ShowUser()
        {
            Console.Clear();
            Console.WriteLine($" ================================");
            Console.WriteLine($" =====       SHOW USER      =====");
            Console.WriteLine($" ================================");
            controller.ShowUsers(); // panggil controller untuk show users
        }
        public void SearchUser()
        {
            Console.Clear();
            Console.WriteLine($" ================================");
            Console.WriteLine($" =====      Search USER     =====");
            Console.WriteLine($" ================================");
            Console.Write($"  Masukkan Username : "); string inputUsername = Console.ReadLine(); // input username
            controller.SearchUser(inputUsername); // panggil controller untuk search user
        }
        public void Login()
        {
            Console.Clear();
            Console.WriteLine($" ================================");
            Console.WriteLine($" =====        LOGIN         =====");
            Console.WriteLine($" ================================");
            Console.Write($"  Masukkan Username : "); string inputUsername = Console.ReadLine();
            Console.Write($"  Masukkan Password : "); string inputPassword = Console.ReadLine();
            controller.LoginUser(inputUsername, inputPassword); // panggil controller untu login
        }

        public void UpdateUser()
        {
            Console.Clear();
            Console.WriteLine($" ================================");
            Console.WriteLine($" =====      Update User     =====");
            Console.WriteLine($" ================================");
            controller.ShowAllUsersByName(); // tampilkan semua user (nama saja)
            Console.Write($" Pilih user yang akan diupdate : "); int pilihUser = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(" User di bawah ini akan diupdate");
            controller.ShowUserById(pilihUser); // tampilkan user yang dipilih
            Console.WriteLine("\n");
            Console.Write($" Masukkan FirstName Baru : "); string inputFirstName = Console.ReadLine();
            Console.Write($" Masukkan LastName Baru  : "); string inputLastName = Console.ReadLine();
            Console.Write($" Masukkan Password Baru  : "); string inputPassword = Console.ReadLine();
            controller.UpdateUser(pilihUser, inputFirstName, inputLastName, inputPassword); // panggil controller update user
            Console.WriteLine($"  Selamat user {inputFirstName} berhasil diupdate");
        }

        public void Delete()
        {
            Console.Clear();
            Console.WriteLine($" =================================");
            Console.WriteLine($" =====      Update User      =====");
            Console.WriteLine($" =================================");
            Console.WriteLine($" User yang ada :");
            controller.ShowAllUsersByName(); // tampilkan semua user (nama saja)
            Console.Write($" Pilih User yang ada dihapus : "); int pilihUser = int.Parse(Console.ReadLine());
            controller.DeleteUser(pilihUser);
            Console.WriteLine($" User Berhasil Dihapus"); // hapus user
        }

    }
}