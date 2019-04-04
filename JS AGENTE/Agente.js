"use strict";
exports.__esModule = true;
var Agente = /** @class */ (function () {
    function Agente(grafoEstados, noInicial) {
        this.grafoEstados = grafoEstados;
        this.grafoEstados.noInicio = noInicial;
    }
    Agente.prototype._inicialize_single_source = function () {
        for (var key in this.grafoEstados.vetor) {
            if (this.grafoEstados.vetor.hasOwnProperty(key)) {
                this.grafoEstados.vetor[key].d = Number.MAX_VALUE;
                this.grafoEstados.vetor[key].pi = undefined;
                this.grafoEstados.vetor[key].descoberto = false;
            }
        }
        this.grafoEstados.noInicio.d = 0;
    };
    Agente.prototype.DFS_visit = function () {
        var contadorDescobertas = 0;
        this._inicialize_single_source();
        var piCorrente = undefined;
        var stack = [];
        stack.push(this.grafoEstados.noInicio.nome);
        while (stack.length != 0) {
            var v = stack[stack.length - 1];
            stack.splice(stack.length - 1, 1);
            contadorDescobertas++;
            this.grafoEstados.vetor[v].d = contadorDescobertas;
            if (!this.grafoEstados.vetor[v].descoberto) {
                this.grafoEstados.vetor[v].descoberto = true;
                for (var key in this.grafoEstados.vetor[v].Adj) {
                    if (this.grafoEstados.vetor.hasOwnProperty(key)) {
                        if (!this.grafoEstados[key].descoberto) {
                            stack.push(key);
                            this.grafoEstados[key].pi = v;
                        }
                    }
                }
            }
        }
    };
    return Agente;
}());
exports.Agente = Agente;
