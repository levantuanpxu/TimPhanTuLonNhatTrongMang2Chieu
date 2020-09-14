namespace LopHinhChuNhat
{
    internal class Aninal
    {
       public string name,sound;
        public Aninal(string name="",string sound="")
        {
            this.name=name;
            this.sound=sound;
        }
        public string GetInfo()
        {
            return "ketqua{" + "name=" + name + "sound=" + sound + "}";
        }
         
    }
}