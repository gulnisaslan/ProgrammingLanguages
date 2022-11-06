public class Main {

    public static void main(String[] args) {
        BaseCrediManager baseCrediManager = new BaseCrediManager();
       System.out.println( baseCrediManager.hesapla(1000));


    BaseCrediManager[] crediManagers = new BaseCrediManager[]{new OgretmenCrediManager(),new TarimCrediManager(),new OgrenciCrediManager()};
      for (BaseCrediManager crediManager:crediManagers ) {
          System.out.println(crediManager.hesapla(crediManager.hesapla(1000)));
      }
    }
}
