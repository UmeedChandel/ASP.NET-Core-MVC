using PieWorkShop.Models;

namespace PieWorkShop.ViewModels
{
    //View Models Folder - custome data eg Student + Count
    public class CustomClass
    {
        public IEnumerable<Student> students{ get; set; }
        public int count { get; set; }
    }
}
