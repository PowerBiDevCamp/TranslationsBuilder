using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslationsBuilder.Services {

  class UserInteraction {


    public static void PromptUserWithInformation(string Message) {
      MessageBox.Show(Message, GlobalConstants.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }


    public static void PromptUserWithWarning(string Message) {
      MessageBox.Show(Message, GlobalConstants.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public static void PromptUserWithError(Exception ex) {
      string errorType = ex.GetType().ToString();
      string errorMessage = ex.Message;
      string messageToUser = errorMessage + "\r\n" + "\r\n" + "Error: " + errorType;
      MessageBox.Show(messageToUser, GlobalConstants.ApplicationName + " Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static void PromptUserWithError(string ErrorMessage) {
      MessageBox.Show(ErrorMessage, GlobalConstants.ApplicationName + " Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }



    public static bool PromptUserToConfirmOperation(string Message, string Operation) {
      var dialogResult = MessageBox.Show(Message, "Confirm " + Operation, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
      return dialogResult == DialogResult.OK;
    }
  }
}
