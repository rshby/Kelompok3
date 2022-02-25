using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kelompok3
{
    class ControllerUser
    {
        List<User> daftarUser = new List<User>();

        public void CreateUser(string inputFirstName, string inputLastName, string inputPassword)
        {
            if (cekPassword(inputPassword) == true)
            { 
                User newUser = new User(inputFirstName, inputLastName, inputPassword);
                daftarUser.Add(newUser);
                Console.WriteLine($"  Selamat User sudah dibuat");
            }
            else
            {
                Console.WriteLine($"  Password Tidak Memenuhi Syarat!!");
            }
        }

        public void ShowUsers()
        {
            for (int i = 0; i < daftarUser.Count; i++)
            {
                Console.WriteLine($"  {i+1}. FirstName : {daftarUser[i].FirstName}");
                Console.WriteLine($"     LastName  : {daftarUser[i].LastName}");
                Console.WriteLine($"     Username  : {daftarUser[i].Username}");
                Console.WriteLine($"     Password  : {daftarUser[i].Password}");
                Console.WriteLine("\n");
            }
        }

        public void ShowAllUsersByName()
        {
            for (int i = 0; i < daftarUser.Count; i++)
            {
                Console.WriteLine($"  {i+1}. {daftarUser[i].FirstName} {daftarUser[i].LastName}");
            }
        }

        public void ShowUserById(int i)
        {
            Console.WriteLine($"  First Name : {daftarUser[i - 1].FirstName}");
            Console.WriteLine($"  Last Name  : {daftarUser[i - 1].LastName}");
            Console.WriteLine($"  Username   : {daftarUser[i - 1].Username}");
            Console.WriteLine($"  Password   : {daftarUser[i - 1].Password}");
        }

        public bool cekPassword(string inputPassword)
        {
            bool cek = false;
            var regexItem = new Regex("[^A-Za-z0-9]");
            bool isNumber = int.TryParse(inputPassword, out int n);
            bool hasSpecialChar = regexItem.IsMatch(inputPassword.ToString()) || isNumber;
            if ((inputPassword.Length >= 8) && ((inputPassword.Any(char.IsUpper)) == true) && (hasSpecialChar == true))
            {
                cek = true;
            }
            return cek;
        }

        public void UpdateUser(int i, string inputFirstName, string inputLastName, string inputPassword)
        {
            if (cekPassword(inputPassword) == true)
            {
                daftarUser[i - 1].FirstName = inputFirstName;
                daftarUser[i - 1].LastName = inputLastName;
                daftarUser[i - 1].Username = inputFirstName.Substring(0, 2) + inputLastName.Substring(0, 2);
                daftarUser[i - 1].Password = inputPassword;
            }
            else
            {
                Console.WriteLine($"  Password Tidak Memenuhi Ketentuan!!");
            }
        }

        public void SearchUser(string inputUsername)
        {
            int index = 0;
            for (int i = 0; i < daftarUser.Count; i++)
            {
                if (inputUsername == daftarUser[i].Username)
                {
                    index = i;
                    Console.WriteLine($"  Hasil Ditemukan");
                    Console.WriteLine($"  FistName : {daftarUser[index].FirstName}");
                    Console.WriteLine($"  LastName : {daftarUser[index].LastName}");
                    Console.WriteLine($"  Username : {daftarUser[index].Username}");
                    Console.WriteLine($"  Password : {daftarUser[index].Password}");
                }
                else
                {
                    Console.WriteLine($" Hasil untuk username : {inputUsername} Tidak Ditemukan");
                }
            }

            
        }

        public void LoginUser(string inputUsername, string inputPassword)
        {
            for (int i = 0; i < daftarUser.Count; i++)
            {
                if ((inputUsername == daftarUser[i].Username) && (inputPassword == daftarUser[i].Password))
                {
                    Console.WriteLine($" Login Berhasil untuk user {daftarUser[i].FirstName} {daftarUser[i].LastName}");
                }
                else
                {
                    Console.WriteLine($" Username dan Password Salah!!");
                }
            }
        }

        public void DeleteUser(int i)
        {
            daftarUser.RemoveAt(i - 1);
        }
    }
}