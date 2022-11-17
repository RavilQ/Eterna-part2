using System.Collections.Generic;

namespace Eterna.Models
{
    public static class Data
    {

        public static List<feature> feature = new List<feature> 
        {
            new feature{Title="Lorem Ipsum",Body= "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
            new feature{Title="Dolor Sitem",Body="Minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat tarad limino ata"},
            new feature{Title="Sed ut perspiciatis",Body="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur"}
        };

        public static List<Service> service = new List<Service>
        {
                new Service{Id=1,Title="Lorem Ipsum",Body="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi",icon="<i class=\"bx bxl-dribbble\"></i>"},
                new Service{Id=2,Title="Sed ut perspiciatis",Body="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore",icon="<i class=\"bx bx-file\"></i>"},
                new Service{Id=3,Title="Magni Dolores",Body="Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia",icon="<i class=\"bx bx-tachometer\"></i>"},
                new Service{Id=4,Title="Nemo Enim",Body="At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis",icon="<i class=\"bx bx-world\"></i>"},
                new Service{Id=5,Title="Dele cardo",Body="Quis consequatur saepe eligendi voluptatem consequatur dolor consequuntur",icon="<i class=\"bx bx-slideshow\"></i>"},
                new Service{Id=6,Title="Divera don",Body="Modi nostrum vel laborum. Porro fugit error sit minus sapiente sit aspernatur",icon="<i class=\"bx bx-arch\"></i>"}
        };

        public static List<Slider> Sliders = new List<Slider>()
        {

            new Slider{Slide="slide-1.jpg"},
            new Slider{Slide="slide-2.jpg"},
            new Slider{Slide="slide-3.jpg"}

        };

        public static List<Cards> card = new List<Cards>
        {
            new Cards{Id=1,Img="team-1.jpg",Title1="Walter White",Title2="Chief Executive Officer",Desc="   Magni qui quod omnis unde et eos fuga et exercitationem. Odio veritatis perspiciatis quaerat qui aut aut aut"},
            new Cards{Id=2,Img="team-2.jpg",Title1="Sarah Jhinson",Title2="Product Manager",Desc="  Repellat fugiat adipisci nemo illum nesciunt voluptas repellendus. In architecto rerum rerum temporibus"},
            new Cards{Id=3,Img="team-3.jpg",Title1="William Anderson",Title2="CTO",Desc="Voluptas necessitatibus occaecati quia. Earum totam consequuntur qui porro et laborum toro des clara"}
        };
    }
}
