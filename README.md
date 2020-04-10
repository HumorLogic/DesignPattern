# DesignPattern设计模式

## 1.设计模式介绍  
设计模式是科学组织设计软件的代码结构，目的是为了能更好的应对软件开发的变化，管理复杂度，易维护  
易扩展，让代码做到：  
1. **可复用**
2. **低耦合**
3. **业务封装**  
> 设计模式的核心是抽象，通过抽象来进行复杂度管理。  
  
  
  
  
## 2. 面向对象设计7大原则 

|   原则    | 内容   |
| :--------|:-----| 
|**①单一职责原则SRP**<img width=70/>|<ol><li>一个类应该有一个，且只有一个引起改变的原因，这意味着一个类应该只有一个职责。</li></ol> | 
|**②开放-封闭原则OCP**|<ol><li>软件(包括类、模块、函数等）应该能够做到可扩展，但不能不修改它。</li></ol>|
|**[③依赖倒转原则DIP](https://github.com/HumorLogic/DesignPattern/tree/master/%E4%BE%9D%E8%B5%96%E5%80%92%E8%BD%AC%E5%8E%9F%E5%88%99)**|<ol><li>高层不依赖底层，双方都应该依赖抽象。</li><li>抽象不依赖细节，而细节应该依赖抽象。</li></ol> | 
|**④里氏替换原则LSP**|<ol><li>子类必须可以替换父类。</li><li>一个可以接受父类对象的地方必然可以接受一个子类对象。</li></ol>|
|**⑤接口隔离原则ISP**|<ol><li>使用多个专门的接口来取代一个统一的接口</li><li>客户端不应该依赖它不需要的接口</li><li>类间的依赖关系应该建立在最小的接口上</li></ol> | 
|**[⑥迪米特原则LKP](https://github.com/HumorLogic/DesignPattern/tree/master/%E8%BF%AA%E7%B1%B3%E7%89%B9%E6%B3%95%E5%88%99)**|<ol><li>一个类对于其他类知道的越少越好，就是说一个对象应当对其他对象有尽可能少的了解，只和朋友通信，不和陌生人说话。</li><li>如果一个类需要调用另一个类的方法的话，可以通过第三者转发这个调用。</li></ol>|
|**⑦合成复用原则CRP**|<ol><li>尽量使用合成/聚合，尽量不要使用类继承。</li></ol>|

## 3.常用的设计模式
|<img width=80/>创建型模式 <img width=80/>|<img width=80/>结构型模式<img width=80/>|<img width=80/>行为型模式 <img width=80/>|  
| :-----------: |:-----------:| :--------:  |  
|1.简单工厂模式 ★★★★☆ | [1.适配器模式](https://github.com/HumorLogic/DesignPattern/tree/master/%E7%BB%93%E6%9E%84%E5%9E%8B%E6%A8%A1%E5%BC%8F/%E9%80%82%E9%85%8D%E5%99%A8%E6%A8%A1%E5%BC%8F) ★★★★☆  | [1.命令模式](https://github.com/HumorLogic/DesignPattern/tree/master/%E8%A1%8C%E4%B8%BA%E5%9E%8B%E6%A8%A1%E5%BC%8F/%E5%91%BD%E4%BB%A4%E6%A8%A1%E5%BC%8F) ★★★★☆| 
|[2.工厂方法模式](https://github.com/HumorLogic/DesignPattern/tree/master/%E5%88%9B%E5%BB%BA%E5%9E%8B%E7%B1%BB%E6%A8%A1%E5%BC%8F/%E5%B7%A5%E5%8E%82%E6%96%B9%E6%B3%95%E6%A8%A1%E5%BC%8F) ★★★★★ | 2.桥接模式 ☆☆☆☆☆   | 2.中介者模式  ☆☆☆☆☆| 
|[3.抽象工厂模式 ](https://github.com/HumorLogic/DesignPattern/tree/master/%E5%88%9B%E5%BB%BA%E5%9E%8B%E7%B1%BB%E6%A8%A1%E5%BC%8F/%E6%8A%BD%E8%B1%A1%E5%B7%A5%E5%8E%82%E6%A8%A1%E5%BC%8F)★★★★★  | 3.装饰模式 ☆☆☆☆☆| [3.观察者模式](https://github.com/HumorLogic/DesignPattern/tree/master/%E8%A1%8C%E4%B8%BA%E5%9E%8B%E6%A8%A1%E5%BC%8F/%E8%A7%82%E5%AF%9F%E8%80%85%E6%A8%A1%E5%BC%8F)  ★★★★★| 
|4.建造者模式  ★★☆☆☆   | [4.外观模式](https://github.com/HumorLogic/DesignPattern/tree/master/%E7%BB%93%E6%9E%84%E5%9E%8B%E6%A8%A1%E5%BC%8F/%E5%A4%96%E8%A7%82%E6%A8%A1%E5%BC%8F)  ★★★★★   | 4.状态模式 ☆☆☆☆☆| 
|5.单例模式  ★★★★☆  | [5.组合模式](https://github.com/HumorLogic/DesignPattern/tree/master/%E7%BB%93%E6%9E%84%E5%9E%8B%E6%A8%A1%E5%BC%8F/%E7%BB%84%E5%90%88%E6%A8%A1%E5%BC%8F) ★★★★☆ | [5.迭代器模式](https://github.com/HumorLogic/DesignPattern/tree/master/%E8%A1%8C%E4%B8%BA%E5%9E%8B%E6%A8%A1%E5%BC%8F/%E8%BF%AD%E4%BB%A3%E5%99%A8%E6%A8%A1%E5%BC%8F) ★★★★★ | 
|6.原型模式 ★★★☆☆|[6.MVC模式](https://github.com/HumorLogic/DesignPattern/tree/master/%E7%BB%93%E6%9E%84%E5%9E%8B%E6%A8%A1%E5%BC%8F/MVC%E6%A8%A1%E5%BC%8F) ★★★★★|[6.策略模式](https://github.com/HumorLogic/DesignPattern/tree/master/%E8%A1%8C%E4%B8%BA%E5%9E%8B%E6%A8%A1%E5%BC%8F/%E7%AD%96%E7%95%A5%E6%A8%A1%E5%BC%8F) ★★★★☆|


