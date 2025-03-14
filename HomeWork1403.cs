using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class HomeWork1403{
    static async Task Prakt1(){
        using HttpClient client = new HttpClient();
        string url = "https://jsonplaceholder.typicode.com/users/50";
        string response = await client.GetStringAsync(url);
        Console.WriteLine(response); 
    }

    static async Task Prakt2(){
        string info = Console.ReadLine();
        using HttpClient client = new HttpClient();
        string url = "https://jsonplaceholder.typicode.com/posts";
        StringContent content = new StringContent(info, Encoding.UTF8, "application/json");
        HttpResponseMessage response = await client.PostAsync(url, content);

        string res = await response.Content.ReadAsStringAsync();
        Console.WriteLine(res);
    }


    static async Task Prakt3(){
        Console.Write("Что делаем?: (get/post) ");
        string user = Console.ReadLine();
        if(user == "get"){
            try{
                using HttpClient client = new HttpClient();
                Console.Write("Какой id?: ");
                string id = Console.ReadLine();
                string url = "https://jsonplaceholder.typicode.com/users/" + id;
                string response = await client.GetStringAsync(url);
                Console.WriteLine(response);
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
        else if(user == "post"){
            try{
                Console.Write("Введите данные: ");
                string info = Console.ReadLine();
                using HttpClient client = new HttpClient();
                string url = "https://jsonplaceholder.typicode.com/posts";
                StringContent content = new StringContent(info, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);

                string res = await response.Content.ReadAsStringAsync();
                Console.WriteLine(res);
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}