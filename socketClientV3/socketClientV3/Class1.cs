namespace socketClientV3
{
    public class socketClient
    {
        int currentAutoId = 0;
        Dictionary<int, pointer> data = new Dictionary<int, pointer>();

        public void addSharedVariable(/* delegate object getFunc(object value), delegate object setFunc(object value),*/ string id = "auto")
        {
            if(id == "auto")
            {
                for(int i  = currentAutoId, pusher = 1; i < pusher;  i++)
                {
                    if(data.ContainsKey(i)) pusher = i;
                    else
                    {
                        data.Add(i, );
                    }
                }
            }
        }
    }
    public class pointer
    {
        public delegate object get;
        public delegate object set;
    }
}