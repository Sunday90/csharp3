namespace csharp.ru {
    public class Prorgam {
      //Метод создает массив строк и возращает новый массив, в котором находятся строки из первого массива не длиннее 3 символов
        public static void Main() {
            string[] array = {"Test1", "Tes", "Te", "Test2"};
            string[] array2 = new string[5];

            for(int i=0; i < array.Length; i++) {
                if(array[i].Length <= 3) {
                    array2[i] = array[i];
                }
            }
        }
    }
}
