"use strict";
exports.__esModule = true;
var Grafo = /** @class */ (function () {
    function Grafo() {
        this.vetor = {};
        this.noInicio = undefined;
    }
    Grafo.prototype.adicionarVetor = function (no) {
        this.vetor[no.nome] = no;
    };
    return Grafo;
}());
exports.Grafo = Grafo;
