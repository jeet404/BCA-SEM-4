class ABC implements Runnable {
    public void run() {
        try {
            Thread.sleep(100);
        } catch (InterruptedException ie) {
            ie.printStackTrace();
        }
        System.out.println(
                "The State of Thread T1 while it invoked the method join() on thread T2 "
                        + ThreadingDemo.T1.getState());
        try {
            Thread.sleep(200);
        } catch (InterruptedException ie) {
            ie.printStackTrace();
        }
    }
}

public class ThreadingDemo implements Runnable {
    public static Thread T1;
    public static ThreadingDemo obj;

    public static void main(String[] args) {
        obj = new ThreadingDemo();
        T1 = new Thread(obj);
        System.out.println("The State of Thread T1 after spawing it " + T1.getState());
        T1.start();
        System.out.println("The State of Thread T1 after invoking method start() on it " + T1.getState());
    }

    public void run() {
        ABC myobj = new ABC();
        Thread T2 = new Thread(myobj);
        System.out.println("The State of Thread T2 after spawing it " + T2.getState());
        T2.start();
        System.out.println("The State of Thread T2 after calling the method start() on it " + T2.getState());
        try {
            Thread.sleep(200);
        } catch (InterruptedException ie) {
            ie.printStackTrace();
        }
        System.out.println("The State of Thread T2 after calling the method start() on it " + T2.getState());
        try {
            T2.join();
        } catch (InterruptedException ie) {
            ie.printStackTrace();
        }
        System.out.println("The State of Thread T2 when it has complated it's execution " + T2.getState());
    }
}
