namespace app
{
    public class BankAccount
    {
        public string v1 {get;set;}
        public string v2;
        public int v3;

        public BankAccount(string v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
        public void Deposit(int v1,int v2){
            try{
            if(v1>v2){
                throw new ArgumentException(nameof(v1),"no deposit");

            }
            }
            catch(ArgumentException e){
                Console.WriteLine("Continue");
            }
        }
    }
}