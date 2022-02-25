class MultiThreadDemo implements Runnable {
    public void run() {
        try {
            System.out.println("Thread " + Thread.currentThread().getId());
        } catch (Exception e) {
            System.out.println("Exception Cought");
        }
    }
}

public class multiThreadingDemo2 {
    public static void main(String[] args) {
        int n = 8;
        for (int i = 0; i < n; i++) {
            Thread object = new Thread(new MultiThreadDemo());
            object.start();
        }
    }
}
