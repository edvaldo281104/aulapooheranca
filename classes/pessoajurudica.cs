namespace poo_Herança.classes
{
    // com : seguido do nome superclasse, utilizamos herança
    public class pessoajurudica : Pessoa
    {
        public string cnpj;

        public string incricaoEstadual;

        public bool ValidarCNPJ(string documento){
            
            if(documento != ""){
                return true;

            }
            return false;

        }
    }
}