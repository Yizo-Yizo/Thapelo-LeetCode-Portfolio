# 🧠 Thapelo Selebedi — LeetCode + SQL Mastery Portfolio

Welcome to my **LeetCode + SQL mastery journey**, part of my roadmap from **October–December 2025**.  
This repository documents my progress in **problem-solving, data structures, algorithms**, and **SQL proficiency**, using **C# (.NET 8)** as my main language.

---

## 📆 Study Timeline
**14 Oct 2025 – 05 Jan 2026**

| Phase | Focus | Deliverables |
|-------|--------|--------------|
| 🧭 Phase 1 | Arrays, Strings, SQL Basics | 20+ LeetCode & SQL problems |
| 🧩 Phase 2 | Data Structures + Joins/Subqueries | 25+ problems |
| ⚙️ Phase 3 | Algorithms + Window Functions | 30+ problems |
| 🚀 Phase 4 | AI-Enhanced Task Tracker | ASP.NET Core Project |
| 🔁 Phase 5 | Reflection + CV Update | GitHub + LinkedIn post |

---

## 🧩 Structure

Each problem folder contains:
- **Problem.md** → Description & constraints  
- **Solution.cs / .sql** → My implementation  
- **Notes.md** → Time complexity & reflection  

---

## 🧠 Example Problem

### Problem: Two Sum
**Link:** [LeetCode #1 – Two Sum](https://leetcode.com/problems/two-sum/)

#### My Solution
```csharp
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int sum = 0;
        int[] indecies = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                sum = nums[i] + nums[j];
                if (target == sum){
                    indecies[0] = i;
                    indecies[1] = j;
                    break;
                }    
            }
            if (target == sum)
                break;
        }
        return indecies;
    }
}

⏱️ Complexity
	•	Time: O(n²)
	•	Space: O(1)

🧭 Reflection
My first solution uses a brute-force nested loop. I plan to optimize it with a HashMap to achieve O(n) time complexity in the next iteration.

---

## 🚀 Upcoming Project

AI-Enhanced Task Tracker — a .NET 8 + EF Core + SQL Server + OpenAI integration
Goal: CRUD app with AI-generated task summaries.

---
## 📫 Connect with Me
	•	💼 LinkedIn: https://www.linkedin.com/in/thapelo-selebedi-a328bb69/￼
	•	🧑🏾‍💻 GitHub: https://github.com/Yizo-Yizo

⭐ This repo is part of my journey toward mastering Data Structures, Algorithms, SQL, and .NET development.

---

