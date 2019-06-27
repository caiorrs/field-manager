using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormVersion.Servidor_Central
{
    public interface iUIExposed
    {

        bool configurarSistema(string cidade, int tipoGrama);
        bool setAltura(float altura);
        void cortarAgora();

        void agendarCorte(DateTime data, float altura);

        String getRelatorioCorte(Business.Periodo periodo);
        String getRelatorioUmidade(Business.Periodo periodo);

        String getTiposDeGrama();

        /*
        configurarSistema(string cidade, int tipoGrama) : bool​:
recebe como parâmetro a localização geográfica do sistema no
formato string, representando a cidade onde se encontra.
Recebe, também, um inteiro representando o id do tipoGrama
registrado na base de dados. Retorna true em caso de sucesso
e false caso contrário.

2. setAltura(float altura): bool​: modifica a altura atual do cortador
inteligente. Retorna true em caso de sucesso e false se houve
algum erro (ex: altura inválida).

3. cortarAgora() : void​: através deste método, o cortador de grama
é ativado para realizar o corte.

4. agendarCorte(dataHora data, float altura): bool​: recebe um
objeto dataHora e a altura do corte a ser feita. Isto seráregistrado no cronograma de cortes do Sistema de Corte.
Retorna true em caso de sucesso e false caso contrário.

5. getRelatorioCorte(periodo): String​: retorna um JSON
representando as informações contidas no Relatório de Corte
relativos ao período requisitado.

6. getRelatorioUmidade(periodo): String​: Retorna um JSON
representando as informações contidas no Relatório de
Umidade relativos ao período requisitado.

7. getTiposDeGrama(): String​: retorna um JSON representando
as informações referentes a todos os tipos de grama
cadastrados no sistema.
*/



    }
}
