namespace iShopping.Utils
{
    /// <summary>
    /// Classe auxiliar para itens do ComboBox.
    /// Permite guardar um texto visível (Display) e um valor escondido (Value).
    /// 
    /// Exemplo de uso num ComboBox de Tipos de Artigo:
    /// - Display = "Alimentação" (o que o utilizador vê)
    /// - Value = 1 (ID do tipo, usado para guardar na BD)
    /// 
    /// O ComboBox chama automaticamente ToString() para saber o que mostrar.
    /// </summary>
    public class ComboBoxItem
    {
        /// <summary>
        /// Texto que aparece visível no ComboBox.
        /// </summary>
        public string Display { get; set; }

        /// <summary>
        /// Valor numérico associado (geralmente um ID da base de dados).
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Cria um novo item para ComboBox.
        /// </summary>
        /// <param name="display">Texto visível</param>
        /// <param name="value">Valor numérico (ID)</param>
        public ComboBoxItem(string display, int value)
        {
            Display = display;
            Value = value;
        }

        /// <summary>
        /// Retorna o texto visível. O ComboBox usa este método automaticamente.
        /// </summary>
        public override string ToString()
        {
            return Display;
        }
    }
}
