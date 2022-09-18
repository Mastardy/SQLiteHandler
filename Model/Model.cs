namespace SQLiteHandler.Model
{
    public partial class Model
    {
        private static Model instance;

        public static Model Instance => instance ??= new Model();

        private Model() { }
    }
}