using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenShots
{
    public partial class SingleResultEntry : Form
    {
        public SingleResultEntry()
        {
            InitializeComponent();
        }

        private void radRadioButton6_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }




//    class FiniteStateMachine
//    {
//        public enum State
//        {
//            ResultNameInputState,
//            ResultNameVerifyState,
//            ResultValueInputState,
//            ResultValueVerifyState,
//            IllegalResultNameState,
//            IllegalResultValueState,
//            LegalResultValueState,
//            CannotCountState,
//            EndState
//        };
//
//        public States State { get; set; }
//
////        public enum Triggers
////        {
////            1,2,
////            ResultNameOkTrigger,
////            ResultNameNotOkTrigger,
////            BackToResultNameInputTrigger,
////            ResultValueEnteredTrigger,
////            RemovePower
////        };
//
////        private Action[,] fsm;
//        Dictionary<States, Dictionary<Trigger,States>> 
//        public FiniteStateMachine()
//        {
//
//
//            this.fsm = new Action[3, 4]
//                               {
//                                   //PlugIn     ,       TurnOn          , TurnOff           , RemovePower
//                                   {this.PowerOn, null                  , null, null}       , //start
//                                   {null        , this.StandbyWhenOff   , null              , this.PowerOff}, //standby
//                                   {null        , null                  , this.StandbyWhenOn, this.PowerOff}
//                               }; //on
//        }
//
//        public void ProcessEvent(Events theEvent)
//        {
//            this.fsm[(int)this.State, (int)theEvent].Invoke();
//        }
//
//        private void PowerOn()
//        {
//            this.State = States.Standby;
//        }
//
//        private void PowerOff()
//        {
//            this.State = States.Start;
//        }
//
//        private void StandbyWhenOn()
//        {
//            this.State = States.Standby;
//        }
//
//        private void StandbyWhenOff()
//        {
//            this.State = States.On;
//        }
//    }

}
