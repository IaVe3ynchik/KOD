using System;
using System.IO;
using HomeWork0402;

namespace HomeWork0703;

class FileManager{
    public string path;

    public FileManager(string p){
        path = p;
    }


    public void ListFiles()
    {
        Console.WriteLine("Файлы и папки в пути: " + path);
        foreach (var file in Directory.GetFiles(path))
        {
            Console.WriteLine(Path.GetFileName(file));
        }
        foreach (var dir in Directory.GetDirectories(path))
        {
            Console.WriteLine(Path.GetFileName(dir));
        }
    }


    public void ChangeDirectory(string newPath)
    {
        string new_path = Path.Combine(path, newPath);
        if (Directory.Exists(path))
        {
            path = new_path;
            Console.WriteLine("Новый путь: " + path);
        }
        else
        {
            Console.WriteLine("Не найден путь: " + newPath);
        }
    }


    public void CopyFile(string oldPath, string pathToCopy){
        string fileName = Path.GetFileName(oldPath);
        if(!File.Exists(pathToCopy)){
            File.Copy(oldPath, pathToCopy);
            Console.WriteLine($"Файл {fileName} скопирован.");
        }
        else{
            Console.Write($"Желаете перезаписать файл {fileName}? (y/n) ");
            char a = Char.Parse(Console.ReadLine());
            if(a == 'y'){
                File.Copy(oldPath, pathToCopy, true);
                Console.WriteLine($"Файл {fileName} скопирован.");
            }
            else if(a == 'n'){
                Console.WriteLine($"Файл {fileName} не скопирован.");
            }
            else{
                Console.WriteLine($"Неверный ввод. {name} не скопирован.");
            }
        }
    }


    public void CopyDir(string oldPath, string pathToCopy){
        if (!Directory.Exists(pathToCopy)){
            Directory.CreateDirectory(pathToCopy);
            foreach (var file in Directory.GetFiles(oldPath))
            {
                string pathToCopy2 = Path.Combine(pathToCopy, Path.GetFileName(file));
                CopyFile(file, pathToCopy2);
            }
            foreach (var dir in Directory.GetDirectories(oldPath))
            {
                string pathToCopy2 = Path.Combine(pathToCopy, Path.GetDirectoryName(dir));
                CopyDir(dir, pathToCopy2);
            }
        }
        else{
            foreach (var file in Directory.GetFiles(oldPath))
            {
                string pathToCopy2 = Path.Combine(pathToCopy, Path.GetFileName(file));
                CopyFile(file, pathToCopy2);
            }
            foreach (var dir in Directory.GetDirectories(oldPath))
            {
                string pathToCopy2 = Path.Combine(pathToCopy, Path.GetDirectoryName(dir));
                CopyDir(dir, pathToCopy2);
            }
        }
    }


    public void CopyDir(string pathToCopy){
        CopyDir(path, pathToCopy);
    }


    public void Info(string name){
        string newPath = Path.Combine(path, name);
        if(File.Exists(newPath)){
            FileInfo finfo = new FileInfo(newPath);
            Console.WriteLine("Информация о файле " + name);
            Console.WriteLine("Вес файла: " + finfo.Length + " байт");
            Console.WriteLine("Создан: " + finfo.CreationTime);
            Console.WriteLine("Последний раз использовался: " + finfo.LastWriteTime);
        }
        else if(Directory.Exists(newPath)){
            DirectoryInfo dinfo = new DirectoryInfo(newPath);
            Console.WriteLine("Информация о папке " + name);
            Console.WriteLine("Вес папки: " + SizeDir(newPath) + " байт");
            Console.WriteLine("Создана: " + dinfo.CreationTime);
            Console.WriteLine("Последний раз использовалась: " + dinfo.LastWriteTime);
        }
        else{
            Console.WriteLine("Не удалось найти файл/папку. Убедитесь, что введено только название(не путь) с форматом(если это файл).");
        }

    }

    private long SizeDir(string pathOfDir){
        long res = 0;
        foreach (var file in Directory.GetFiles(pathOfDir))
        {
            res += new FileInfo(file).Length;
        }
        foreach (var dir in Directory.GetDirectories(pathOfDir))
        {
            res += SizeDir(dir);
        }
        return res;
    }


    public void Delete(string name){
        Console.Write($"Вы действительно желаете удалить {name}? (y/n) ");
        char a = Char.Parse(Console.ReadLine());
        if(a == 'y'){
            string newPath = Path.Combine(path, name);
            if(File.Exists(newPath)){
                File.Delete(newPath);
                Console.WriteLine($"Файл {name} удален");
            }
            else if(Directory.Exists(newPath)){
                var dir = new DirectoryInfo(newPath);
                dir.Attributes = dir.Attributes & ~FileAttributes.ReadOnly;
                dir.Delete(true);
                Console.WriteLine($"Папка {name} удалена");
            }
            else{
                Console.WriteLine("Не удалось найти файл/папку. Убедитесь, что введено только название(не путь) с форматом(если это файл).");
            }
        }
        else if(a == 'n'){
            Console.WriteLine($"{name} не удален(а).");
        }
        else{
            Console.WriteLine($"Неверный ввод. {name} не удален(а).");
        }
    }

}

class HomeWork0703{
    public static void Main(){
        string pathExit = "Последнее_сохранение.txt";
        string path;
        if(File.Exists(pathExit)){
            path = File.ReadAllText(pathExit);
        }
        else{
            path = Directory.GetCurrentDirectory();
        }
        FileManager fmanager = new FileManager(path);
        while(true){
            string mess = Console.ReadLine().Trim();
            string[] splitMess = mess.Split(" ");
            if(splitMess[0] == "cd" & splitMess.Length == 2){
                fmanager.ChangeDirectory(splitMess[1]);
                path = fmanager.path;
            }
            else if(mess == "ls"){
                fmanager.ListFiles();
            }
            else if(splitMess[0] == "copy"){
                if(splitMess.Length == 3){
                    if(File.Exists(splitMess[1])) fmanager.CopyFile(splitMess[1], splitMess[2]);
                    else if(Directory.Exists(splitMess[1])) fmanager.CopyDir(splitMess[1], splitMess[2]);
                    else Console.WriteLine("Убедитесь в верном написании папки/файла");
                }
                else if(splitMess.Length == 2){
                    fmanager.CopyDir(splitMess[1]);
                }
                else Console.WriteLine("Убедитесь в отсутствии лишних пробелов и верном количестве аргументов.");
            }
            else if(splitMess[0] == "info"){
                if(splitMess.Length == 2) fmanager.Info(splitMess[1]);
                else if(splitMess.Length == 1) fmanager.Info(path);
            }
            else if(splitMess[0] == "del" & splitMess.Length == 2){
                fmanager.Delete(splitMess[1]);
            }
            else if(mess == "exit"){
                break;
            }
            else{
                Console.WriteLine("Убедитесь в верном написании команды, отсутствии лишних пробелов и верном количестве аргументов.");
            }
        }
        File.WriteAllText(pathExit, fmanager.path);
    }
}