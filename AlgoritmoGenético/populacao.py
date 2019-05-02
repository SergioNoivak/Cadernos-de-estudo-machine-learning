import individuo
class populacao:
    def __init__(self,tamanho,inicioIntervalo,fimIntervalo):
        self.vetor = []
        for i in range(0,tamanho):
            self.vetor.append(individuo.Individuo(inicioIntervalo,fimIntervalo))
        self.tamanho = tamanho
            
    def exibir(self):
        for elemento in self.vetor:
            elemento.exibir()
               
    
    