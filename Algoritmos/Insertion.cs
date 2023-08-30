// Aprendendo Algoritmo de Inserção


public class Insertion
{
    
    public int[] arr = {4,8,7,4,0,9};

    public void InsertionSort()
    {
        int n = arr.Length; // Definindo o tamanho do meu array numa Variável
    
        for(int i = 1; i<n; i++) // Começamos sempre pelo 2 item do nosso array me vamos comparando da direita para esquerda
        {
            int chave = arr[i]; // Definindo a variável que ira guardar o valor a ser comparado
            int j = i - 1; // Índice do Item que antecede a chave;

            while(j >= 0 && arr[j] > chave) // Será verdadeiro se o índice(j) for maior ou igual a 0(Ou seja um índice que esta dentro do meu array) e o valor[j] for maior que minha chave[valor atual]
            {
                arr[j + 1] = arr[j]; // Caso o a sentença seja verdadeira, mude o valor a direita para o valor array[J + 1] para o valor array[j].
                j--;

                arr[j + 1] = chave;
            } 
        }

        Console.WriteLine($"{arr[0]},{arr[1]},{arr[2]},{arr[3]},{arr[4]},{arr[5]}");
    }
}

// Explicando como funciona o código -->

/*

int[] arr = {4,8,7,4,0,9}; <- Array definido

InsertionSort(arr); < - Chamando método

public static void InsertionSort(int[] arr)
{
    int n = arr.Length; < - Array de tamanho 6
    
    for(int i = 1; i<n; i++) < - i = 1 \\ i = 2
    {
        int chave = arr[i]; < - arr[1] = 8 \\ arr[2] = 7

        int j = i - 1; < - j = 0 \\ j = 1

        while(j >= 0 && arr[j] > chave) < - 4 > 8 (false) \\ 8 > 7
        {
            arr[j + 1] = arr[j]; < - array[2] = array[1] - > {4,7,8}
            j--; < - j = 0;

            arr[j + 1] = chave; < - 
        } 
    }
}








*/