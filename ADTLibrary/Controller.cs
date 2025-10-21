namespace ADTLibrary
{
    public class Controller
    {
        private readonly IStack<Instrumento> _stack;//variable abstact

        public Controller(IStack<Instrumento> stack) //inicializa
        {
            _stack = stack;
        }

        public void AgregarInstrumento(string serie, string modelo)
        {
            if (string.IsNullOrWhiteSpace(serie))
                throw new ArgumentException("La serie es obligatoria.", nameof(serie));

            if (string.IsNullOrWhiteSpace(modelo))
                throw new ArgumentException("El modelo es obligatorio.", nameof(modelo));

            _stack.Push(new Instrumento(serie, modelo));
        }

        public Instrumento SacarInstrumento() => _stack.Pop();

        public Instrumento VerUltimo() => _stack.Peek();

        public int ContarInstrumentos() => _stack.Count;

        public bool EstaVacio() => _stack.IsEmpty();
    }

}
