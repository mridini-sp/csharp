using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorStudentApp.Models;

namespace RazorStudentApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Student Student {  get; set; }= new Student();
        public bool Submitted { get; set;  }
        public void OnGet()
        {
        }
        public void OnPost() 
        {
            Submitted = true;
        }
    }
}
