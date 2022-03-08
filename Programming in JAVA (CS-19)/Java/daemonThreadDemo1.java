class myThread extends Thread {
    public void run() {
        System.out.println("User Thread Deumon or Not");
    }
}

public class daemonThreadDemo1 {
    public static void main(String[] args) {
        myThread mt = new myThread();
        mt.start();
        System.out.println("Is" + mt.getName() + "a daemon Thread" + mt.isDaemon());
        System.out.println(
                "Is" + Thread.currentThread().getName() + "a daemon Thread" + Thread.currentThread().isDaemon());
    }
}
