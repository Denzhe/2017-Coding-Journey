using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AI_Learning_Game
{
  [Serializable]  class BTTree
    {

        BTNode rootNode;

        public BTTree(string question,string yesGuess,string noGuess)
        {
            rootNode = new BTNode(question);

            rootNode.SetYesNode(new BTNode(yesGuess));
            rootNode.SetNoNode(new BTNode(noGuess));

            IFormatter formatter = new BinaryFormatter();

            using (FileStream stream = File.Create("serialized.bin"))
            {
                formatter.Serialize(stream, this);
            } 
        }

        public void Query()
        {
            rootNode.Query();
        }
    }
}
