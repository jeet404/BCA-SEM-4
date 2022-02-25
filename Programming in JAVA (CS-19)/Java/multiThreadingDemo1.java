class MultiThreadDemo extends Thread {

    public void run() {
        try {
            System.out.println("Thread " + Thread.currentThread().getId());
        } catch (Exception e) {
            System.out.println("Exception Cought");
        }
    }
}

public class multiThreadingDemo1 {
    public static void main(String[] args) {
        int n = 8;
        for (int i = 0; i < n; i++) {
            MultiThreadDemo object = new MultiThreadDemo();
            object.start();
        }
    }
}
