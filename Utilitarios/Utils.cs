namespace Desafio1_Rocketseat.Utilitarios
{
    public enum LetrasMinusculas
    {
        a,
        b, 
        c, 
        d, 
        e, 
        f, 
        g, 
        h, 
        i, 
        j, 
        k, 
        l, 
        m, 
        n, 
        o, 
        p, 
        q, 
        r, 
        s, 
        t, 
        u, 
        v, 
        w, 
        x, 
        y, 
        z
    }

    public enum LetrasMaiusculas
    {
        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H, 
        I, 
        J, 
        K, 
        L, 
        M, 
        N, 
        O, 
        P, 
        Q, 
        R, 
        S, 
        T, 
        U, 
        V, 
        W, 
        X, 
        Y, 
        Z
    }

    internal static class Utils
    {
        public static void Printar(string texto) => Console.WriteLine("\n" + texto);

        public static double Soma(double numero1, double numero2) => numero1 + numero2;

        public static double Subtracao(double numero1, double numero2) => numero1 - numero2;

        public static double Multiplicacao(double numero1, double numero2) => numero1 * numero2;

        public static double Divisao(double numero1, double numero2)
        {
            if (numero2 == 0.0) 
            {
                return double.NaN;
            }
            else if(numero1 == 0.0)
            {
                return 0.0;
            }
            else
            {
                return numero1 / numero2;
            }
        }

        public static double Media(double numero1, double numero2) => (numero1 + numero2) / 2;
    }
}
