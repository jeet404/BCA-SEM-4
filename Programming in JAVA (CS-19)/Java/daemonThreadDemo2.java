class myThread extends Thread {
    @Override
    public void run() {
        System.out.println("Non-Daemon Thread.");
    }
}

public class daemonThreadDemo2 {
    public static void main(String[] args) {
        myThread mt = new myThread();
        System.out.println("Before Using setDaemon() ");
        System.out.println("Is " + mt.getName() + " a Daemon Thread " + mt.isDaemon());
        mt.setDaemon(true);
        System.out.println("After using setDaemon() Method : ");
        System.out.println("Is" + mt.getName() + " a Daemon Thread : " + mt.isDaemon());
    }
}
