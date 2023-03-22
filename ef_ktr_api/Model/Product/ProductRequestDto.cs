namespace ef_ktr_api.Model.Product
{
    public class ProductRequestDto
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }
        public int IdCategory { get; set; }
    }
}
