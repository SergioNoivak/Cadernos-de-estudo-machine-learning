
import populacao
import sys
import individuo
from random import randint
import view

def AlgoritmoGenetico(tamanhoPopulacao,inicioIntervalo,fimIntervalo,taxaElitismo,taxaMutacao):
    p= populacao.populacao(10,0,5)
    
    
    for i in range(0,10):
        elite = operadorElitismo(taxaElitismo,p)
        p.exibir()
        selecao_natural(p,elite)
        indice_aleatorio = randint(0, tamanhoPopulacao-1)
        p.vetor[indice_aleatorio].mutar(inicioIntervalo,fimIntervalo)
    
    resultado = melhorElemento(p,inicioIntervalo,fimIntervalo)
    view.exibir_funcao(resultado.ponto.x,resultado.ponto.y)
        

def operadorElitismo(taxaElitismo,p):
        elite = []
            
        p.vetor.sort(key=lambda ind: ind.ponto.y,reverse=True)
        contadorDeRicos =0
        for carinha in p.vetor:
            if(contadorDeRicos<taxaElitismo):
                elite.append(carinha)
                contadorDeRicos=contadorDeRicos+1
             
            else:
                break
        return elite
        
        
def selecao_natural(p,elite):
            p.vetor.sort(key=lambda ind: ind.ponto.y)
            for i in range(0,len(elite)):
                p.vetor[i].ponto.x = elite[i].ponto.x
                p.vetor[i].ponto.y = elite[i].ponto.y
                



def melhorElemento(p,inicioIntervalo,fimIntervalo):
    melhor = individuo.Individuo(inicioIntervalo,fimIntervalo)
    melhor.ponto.x=melhor.ponto.y = -999999999999
    for elemento in p.vetor:
        if(elemento.ponto.y>melhor.ponto.y):
            melhor.ponto.y=elemento.ponto.y
            melhor.ponto.x=elemento.ponto.x
        
    return melhor
    
    
    
        
        
            
            
            
            

            

            
            
            
    
    




    
    
    