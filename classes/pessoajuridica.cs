namespace POO_Heranca.classes
{
    //com: seguido do nome da superclasse, utilizamos a herança
    public class pessoajuridica : pessoa
    {
        public string cnpj;

        public string inscriçaoEstadual;

        public bool ValidarCNPJ(string documento){
         
         if(documento != ""){
             return true;
         }
         return false;
        }
    }
}