programa
{
	
	funcao inicio()
	{
		inteiro janeiro, fevereiro, marco, abril, total, media
		cadeia nome

		escreva ("Insira seu nome e sobrenome: ")
		leia (nome)
		escreva ("insira sua quantidade de vendas do mês de janeiro: ")
		leia (janeiro)
		escreva ("insira sua quantidade de vendas do mês de fevereiro: ")
		leia (fevereiro)
		escreva ("insira sua quantidade de vendas do mês de março: ")
		leia (marco)
		escreva ("insira sua quantidade de vendas do mês de abril: ")
		leia (abril)

		total = janeiro+fevereiro+marco+abril
		media = total/4

		escreva (nome + " seu total de vendas foi: " + total + " e sua média de vendas foi: " + media)
		}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 37; 
 * @PONTOS-DE-PARADA = 9, 10;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */