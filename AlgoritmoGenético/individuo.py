
import Ponto as Ponto
import random
import numpy as np

class Individuo():
    def __init__(self,inicioIntervalo,fimIntervalo):
        self.ponto = Ponto.Ponto(0,0)
        self.mutar(inicioIntervalo,fimIntervalo)

    def mutar(self,inicioIntervalo,fimIntervalo):
          self.ponto.x= random.uniform(inicioIntervalo, fimIntervalo)
          self.ponto.y= self.ponto.x* np.sin(self.ponto.x*self.ponto.x)/(3-np.cos(np.e)-self.ponto.x)
          
    def exibir(self):
          self.ponto.exibir()
