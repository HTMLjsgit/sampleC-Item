    void Start()
    {
        //サンプルコード
        List<string> item_list = new List<string>(); //Listというのを使ってアイテム機能を作る

        item_list.Add("アイテム１"); //アイテム１という配列[List]をつくる  => 配列[0]
        item_list.Add("アイテム2");//アイテム２という配列[List]をつくる  => 配列[1]
        item_list.Add("アイテム３");//アイテム３という配列[List]をつくる => 配列[2]

        int itemCount = item_list.Count; //アイテムのすべての数を取得    
        Debug.Log(itemCount); //アイテムのすべての数を表示


        Debug.Log(item_list[0]); //アイテム　

        foreach (var item_all in item_list) //foreachでアイテムすべてを取得　item_allに定義
        {
            Debug.Log(item_all); //foreachで取得したすべてのアイテムを表示
        }

    }
