namespace poo_Herança.classes
{
    public class PessoasFissica : Pessoa
    {
        public string cpf;

        public string rg;

        public bool ValidarCPF(string documento){

            if(documento != ""){
                return true;
            }

            return false;

            

            
        }

    }
}