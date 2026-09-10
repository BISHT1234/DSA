/*
Floyd's Cycle Detection Algorithm is a technique used in a linked list to detect whether a cycle exists and, with a small extension, to find the starting node of that cycle.

It uses two pointers:

slow → moves 1 node at a time
fast → moves 2 nodes at a time

Why does this detect a cycle?

Consider:

1 → 2 → 3 → 4 → 5 → 6
    ↑                   ↓
    └───────────────────┘

Here, 6 points back to 2.

If there is a cycle, fast moves faster than slow, but eventually fast catches up to slow inside the cycle.

If there is no cycle, fast eventually reaches null.

*/
ListNode slow = head;
ListNode fast = head;

while (fast != null && fast.next != null)
{
    slow = slow.next;
    fast = fast.next.next;

    if (slow == fast)
    {
        return true;
    }
}

return false;
/* To find the starting node of the cycle,
 we can reset one pointer to the head of the list and
  move both pointers one step at a time. The point at which
 they meet will be the starting node of the cycle. */

slow = head;
 while (slow != fast)
{
    slow = slow.next;
    fast = fast.next;
}

return slow;

/*Floyd's algorithm = slow moves 1 step + fast moves 2 steps; if they meet, a cycle exists, and resetting one pointer to head and moving both at 1 step finds the cycle's start.*/