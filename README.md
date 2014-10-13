WinFormSample
=============

Windows Form Sample

以下、とりあえずメモ書きそのまま↓
  
  
・C#ではなくVB.netなのは大人の事情    
・Window Formなのも大人の事情  

つかいかた  
・WinFormSmple　から起動  
　コンボボックスからコントロール名を選ぶと、WinFormSample.Control 内の該当のコントロールを表示（する予定）  

  
各Contorolについて  
・全般  
　コントロール毎にディレクトリを分離（一部共通パーツはCommonディレクトリ内）  
　Ctl（Control）、VM（ViewModel）は１：１　Ctlのバインド対象の型も基本的にVM内に定義  
　※コントロールに名前空間つけられないような・・・？  
　ほんとは名前空間とかつけるべきだけど全くつけてない  
  
・ColorGridView  
　DataGridViewを操作すると編集した部分だけ色が変わる。  
　・Add：行追加　追加行は編集とは別の色  
　・Delete：削除はグレーアウト等ではなく画面上から行を消す  
　　　（表示しているとさらに編集とかできてしまうので、表示上は削除　内部的には保持している）  
　・Submit：用意はしたけど特にDB登録とかしないので空  
　  
　DataGridView設定  
　　RowHeaderVisible=False  
　　SelectionMode=FullRowSelect(にしないとDelete失敗するかも)  
　  
　色変更の使い方  
　　バインド用のデータをBindingListで用意し、BindingSoureにセット  
　　色を変えたいDataGridViewをCellColorFormatter(Of T As ColorStatus)に入れる  
　　（セルの色はBindingSoureではなく、DataGridViewが管理している）  
　　セル・行編集時にColorStatus.Statusを更新する  
  
　カテゴリのコンボボックスについて  
　　つくりかた：  
　　　CategoryId(Integer)のカラムを表示（Category型のカラムではない）  
　　　入力をコンボボックスにする  
　　　Category型のDataSourceをセットし、 Value=Id Display=Name という感じ  
　　　選ぶとCategoryIdが変わる。（ProductがCategory型でデータ持つ意味は無かった…むしろ矛盾出る）  
　　  
　　外観をさらに　DisplayStyleCurrentCellOnly=True　で、セル選択中以外は外観がテキストと同じになる  
　　ChainedComboBoxと同じことを行単位でやろうと思ったけど断念したのでカテゴリ２は未作成。。  
　　イベントがたぶん違うと思うので調査要  
  
・MultiSelectList  
　複数要素の選択によくある　候補リスト←→選択済リスト  
　中身はDataGridView  
　ただ現在の実装だと、リストの順番が変わってしまう　ソートが必要  
  
・ChainedComboBox  
　コンボ１：大分類　コンボ２：その中の小分類　の連携  
　・仕様  
　　１．画面の初期表示で、コンボ１、コンボ２を表示　→コンボ２の値変化をイベントで拾う  
　　２．コンボ１で大項目を選択　→コンボ２：大分類内の小分類を表示  
　　　　そのとき、コンボ２の値が変わる　→コンボ２の値変化をイベントで拾う  
　　３．コンボ２で少項目を選択　→コンボ２の値変化をイベントで拾う  
　・画面上でコンボボックスを操作しなくても値が変わったら検出　とするため、SelectedValueChangedを使用  
　　イベントが頻繁に発生するのでちょっと考慮が必要  
　　（InitializeComponent()中に発生→画面表示前に死ぬとか）  
  
  
  
  
  
