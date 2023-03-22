namespace ef_ktr_api.Model.Product
{
    public class ProductReponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }
        public bool Continue { get; set; }
        public int IdCategory { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
