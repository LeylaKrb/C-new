using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities;



public class Course //her bir kursta bu 4 veriyi bulundurucak//sınıfımız ve alt başlıklarda bu sınıfın özellilkleri
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price {  get; set; }


}
