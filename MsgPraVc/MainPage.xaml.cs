using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MsgPraVc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        Random random = new Random();

        void MensagemPraVc(Object Sender, EventArgs e)
        {
            string[] conteudo = { "O sucesso nasce do querer, da determinação e persistência em " +
            	"se chegar a um objetivo. Mesmo não atingindo o alvo, quem busca e " +
            	"vence obstáculos, no mínimo fará coisas admiráveis.",

                "Determinação, coragem e auto-confiança são fatores decisivos para o sucesso. Se estamos " +
                "possuídos por uma inabalável determinação, conseguiremos superá-los. Independentemente das " +
                "circunstâncias, devemos ser sempre humildes, recatados e despidos de orgulho.",

                "Agir, eis a inteligência verdadeira. Serei o que quiser. Mas tenho que querer o que for. " +
                "O êxito está em ter êxito, e não em ter condições de êxito. Condições de palácio tem qualquer " +
                "terra larga, mas onde estará o palácio se não o fizerem ali?",

                 "Lute. Acredite. Conquiste. Perca. Deseje. Espere. Alcance. Invada. Caia. Seja tudo o quiser ser, " +
                 "mas acima de tudo, seja você sempre.", 
         };

            Mensagem_label.Text = conteudo[random.Next(0, (conteudo.Length - 1))];
        }
    }
}
