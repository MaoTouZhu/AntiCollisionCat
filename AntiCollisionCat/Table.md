﻿# 目标
在任何情况下阻止程序错误和人为误操作将会造成的撞机行为.
面向实际情况, 追求简单高效, 通俗易懂, 便于理解和普及.

# 思路
采集设备实时数据, 计算和组织模型数据, 借助 Jitter2 开始预测性模拟.

# 接口
* 采集设备数据接口
* 

# 杂项
* 试教系统是必要的, 用于某些精密部件.
* 单线程, 不能使用多线程.
* 熔断机制, 一旦某一模拟发现碰撞立即退出报告.

## 世界线实现

### 当前世界线
按预定Tick获取轴和IO的状态, 计算与上一个世界的差异, 生成各个刚体的位置和速度运动, 


# 灵感
* 用世界线变动描述监测系统, 缓存旧世界线, 自然而然地根据当前世界线和旧世界线分裂出预测世界线.
* 使用 Jitter2 简化版本, 使用类似于平行时空的结构, 同时可能有多个世界在模拟验演算? 
* 使用实例化,可部署在单独的设备上,通过网络为整线提供安全服务

# 刚体
盒子
射线
气缸封装
有无

# 轴
* 直线轴
* 旋转轴

# 系统

## 方向和结论
只有过去和未来两个世界线, 过去世界线用于储存上一步的各个部件状态, 当前世界获取实现部件状态和部件规划, 生成模型,
注入参数, 开始模拟, 向未来世界线推演指定时间, 这个推演的指定时间就是预警时间, 若出现碰撞则产生预警, 若未命中碰撞,
则视情况是否休眠, 等待下一个计划世界线, 重新向现实世界采样, 进入下一个循环.

## 运动前验算 (作废)
我司现在的系统是有点困难的, 因为每次安全检验都是一个一个轴地进行安全检查, 有点难拖动软件平台开放接口, 
但是可以先实现, 后面再让软件平台开放. 要不直接抛弃这个功能, 所有数据基于现实当前状态进行推算, 上位机只提供目标位置, 
以让模型在指定位置停下

## 实时碰撞预测
如果基于现在软件平台离散地安全检查, 有概率会将一个本应安全的多轴运动动作, 误判为危险的动作, 这个情况如何解决???
缩短模拟时间? 延后预警时间? 你快撞我再预警?

# 驱动
* 轴驱动
* IO驱动



