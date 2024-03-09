using ArvoreBinariaPTI.models;

ArvoreBinaria arvore = new ArvoreBinaria();

arvore.Adiciona(555);
arvore.Adiciona(888);
arvore.Adiciona(333);
arvore.Adiciona(999);
arvore.Adiciona(444);
arvore.Adiciona(111);

Console.WriteLine($"Número de nós a esquerda: {arvore.ContarEsquerdaFestiva()}");
Console.WriteLine();
arvore.Imprimir();






    