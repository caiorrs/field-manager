using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormVersion.Sistema_de_Corte
{
    interface iCorte//: iSistema
    {
        /*
         agendarCorte(dataHora data, float altura): bool​: através dos
parâmetros recebidos, cria um objeto do tipo AgendamentoCorte
e o adiciona ao Cronograma do sistema. Retorna true em caso
de sucesso e false caso contrário.*/

        void agendarCorte(Business.Agendamento corteAgendado);



        /*
2. cortar(): void​: ativa o cortador de grama para realizar o corte.
3. setAltura(float altura): bool​: modifica a altura atual do cortador
inteligente. Retorna true em caso de sucesso e false, do
contrário false. */


    }
}
