/*239. Sliding Window Maximum

Pattern: Sliding Window + Monotonic Deque

Key idea:
Deque stores indices in decreasing order of values.
x>y>z
Front = maximum of current window.

When to Remove ?
1- Remove from back when incoming value is hight then last element
2- Remove from front when index reches the out side of window length. 
eg:- K=3 window =[0,1,2] and i =3

Why remove back?
Smaller values can never become maximum while bigger value is present.

Why remove front?
Index has left the window.

when to calculate ?
calculate mix  when index is greater then K-1
eg:- window =[0,1,2] and i =3 then calculate the max; 
*/
  public int[] MaxSlidingWindow(int[] nums, int k) {
    List<int> result = new List<int>();
    LinkedList<int> deque = new LinkedList<int>();

    for(int i=0;i<nums.Length;i++){
   
    if(deque.Count>0 && deque.First.Value <= i - k){
        deque.RemoveFirst();
    }
    while(deque.Count>0 && nums[deque.Last.Value] <= nums[i]){
        deque.RemoveLast();
    }
    deque.AddLast(i);

    if(i>= k-1){
 result.Add(nums[deque.First.Value]);
    }

    }
    return result.ToArray();
    }