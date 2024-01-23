using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using static CursoCSharp.OO.Cachorro;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolação.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Formatando números - Fundamentos", FormatandoNumeros.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador ternário - Fundamentos", OperadorTernario.Executar},

                // Estruturas de controle
                {"Estrutura If - Estruturas de controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas de controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estruturas de controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de controle", EstruturaWhile.Executar},
                {"Estrutura DO While - Estruturas de controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de controle", EstruturaFor.Executar},
                {"Estrutura For Each - Estruturas de controle", EstruturaForEach.Executar},
                {"Usando break - Estruturas de controle", UsandoBreak.Executar},
                {"Usando continue - Estruturas de controle", UsandoContinue.Executar},

                // Classes e métodos
                {"Membros - Classes e métodos", Membros.Executar},
                {"Construtores - Classes e métodos", Construtores.Executar},
                {"Metodos com retorno - Classes e métodos", MetodosComRetorno.Executar},
                {"Metodos estaticos - Classes e métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e métodos", AtributosEstaticos.Executar},
                {"Desafio atributos - Classes e métodos", DesafioAtributos.Executar},
                {"Params - Classes e métodos", Params.Executar},
                {"Parametros nomeados - Classes e métodos", ParametrosNomeados.Executar},
                {"Get Set - Classes e métodos", GetSet.Executar},
                {"Props - Classes e métodos", Props.Executar},
                {"Readonly - Classes e métodos", Readonly.Executar},
                {"Enum - Classes e métodos", ExemploEnum.Executar},
                {"Struct - Classes e métodos", Struct.Executar},
                {"Struct Vs Classe - Classes e métodos", StructVsClasse.Executar},
                {"Valor Vs Referência - Classes e métodos", ValorVsReferencia.Executar},
                {"Parametros por Referência - Classes e métodos", ParametrosPorReferencia.Executar},
                {"Parametro com valor padrão - Classes e métodos", ParametroPadrao.Executar},

                // Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Arrey List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},

                // OO
                {"Heranca - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                // Métodos & funções
                {"Exemplo Lambda - Métodos & Funções", ExemploLambda.Executar},
                {"Lambdas como Delegates - Métodos & Funções", LambdasDelegate.Executar},
                {"Usando Delegates - Métodos & Funções", UsandoDelegate.Executar},
                {"Delegates Com Função Anonima - Métodos & Funções", DelegateFunAnonima.Executar},
                {"Delegates Com parametros - Métodos & Funções", DelegatesComParametros.Executar},
                {"Metodos de extensão - Métodos & Funções", MetodosDeExtensao.Executar},

                // Exceções
                {"Primeira Excessão - Exceções", PrimeiraExcecao.Executar},
                {"Exceções personalizadas - Exceções", ExecoesPersonalizadas.Executar},

                // Api
                {"Primeiro arquivo - Usando API", PrimeiroArquivo.Executar},
                {"Lendo arquivos - Usando API", LendoArquivos.Executar},
                {"Exemplo file info - Usando API", ExemploFileInfo.Executar},
                {"Diretórios - Usando API", Diretorios.Executar},
                {"Exemplo directory info - Usando API", ExemploDirectoryInfo.Executar},
                {"Exemplo path - Usando API", ExemploPath.Executar},
                {"Exemplo Date Time - Usando API", ExemploDateTime.Executar},
                {"Exemplo Time Span - Usando API", ExemploTimeSpan.Executar},

                // Tópicos avancados
                {"LINQ #01 - Tópicos avancados", LINQ1.Executar},
                {"LINQ #02 - Tópicos avancados", LINQ2.Executar},
                {"Nullables - Tópicos avancados", Nullables.Executar},
                {"Dynamics - Tópicos avancados", Dynamics.Executar},
                {"Genricos - Tópicos avancados", Genericos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}