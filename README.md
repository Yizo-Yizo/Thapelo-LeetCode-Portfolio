# 🧠 Thapelo Selebedi — LeetCode + SQL Mastery Portfolio

Welcome to my **LeetCode + SQL mastery journey**, part of a focused learning roadmap running from **December 2025 to March 2026**.

This repository documents my progress in:

* 🧩 **Problem-solving**
* ⚙️ **Data Structures & Algorithms**
* 🗄️ **SQL (from fundamentals to advanced analytics)**

My primary implementation language is **C# (.NET 8)**.

## 📆 Study Timeline

**23 Dec 2025 – 16 Mar 2026**

| Phase      | Focus                              | Deliverables                |
| ---------- | ---------------------------------- | --------------------------- |
| 🧭 Phase 1 | Arrays, Strings, SQL Basics        | 20+ LeetCode & SQL problems |
| 🧩 Phase 2 | Data Structures, Joins, Subqueries | 25+ problems                |
| ⚙️ Phase 3 | Algorithms, Window Functions       | 30+ problems                |
| 🚀 Phase 4 | AI-Enhanced Task Tracker           | ASP.NET Core project        |
| 🔁 Phase 5 | Reflection & CV Update             | GitHub + LinkedIn post      |

## 🧩 Repository Structure

Each problem folder contains:

* **`Problem.md`** → Problem description & constraints
* **`Solution.cs` / `.sql`** → My implementation
* **`Notes.md`** → Time & space complexity, reflections, and optimizations

This structure encourages clarity, repeatability, and deliberate learning.

## 🧠 Example Problem

### Problem: Two Sum

🔗 **LeetCode #1 – Two Sum**
[https://leetcode.com/problems/two-sum/](https://leetcode.com/problems/two-sum/)

### My Solution (C#)

```csharp
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] indices = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    indices[0] = i;
                    indices[1] = j;
                    return indices;
                }
            }
        }

        return indices;
    }
}
```

📝 **Notes**

* Time Complexity: **O(n²)**
* Space Complexity: **O(1)**
* This solution prioritizes clarity before optimization.
* Future iterations will include a hash-map based **O(n)** approach.

## 🚀 Upcoming Project

### 🤖 AI-Enhanced Task Tracker

A full-stack **ASP.NET Core** application designed to:

* Track daily learning tasks and progress
* Use AI to summarize completed work
* Recommend next study topics based on performance
* Store insights and analytics in SQL

This project bridges **algorithms, SQL, and AI-assisted productivity** into a real-world system.

## 🔁 Reflection Goals

By the end of this journey, I aim to:

* Demonstrate consistent algorithmic thinking
* Show strong improvement in SQL fluency
* Maintain clean, explainable, and maintainable code
* Translate learning into practical, production-minded systems

## 🤝 Connect With Me

* 🧑‍💻 **GitHub:** [https://github.com/Yizo-Yizo](https://github.com/Yizo-Yizo)
* 💼 **LinkedIn:** [https://www.linkedin.com/in/thapelo-selebedi-a328bb69](https://www.linkedin.com/in/thapelo-selebedi-a328bb69)

If you’re on a similar learning path or interested in collaboration, feel free to connect.
