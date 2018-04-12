# RabbitMQ

O <b>RabbitMQ</b> é um software open source, que visa disponibilizar uma estrutura que facilite fluxos de mensagens, sobretudo em grandes aplicações, para a comunicação entre todos os processos. Arquiteturalmente ele utiliza o Advanced Message Queuing Protocol (AMQP), que suporta o protocolo de mensagens e utiliza também, o Hypertext Transfer Protocol(HTTP), que é a base da comunicação de dados. Através da solução, é possível criar uma aplicação para lidar com o tráfego de mensagens que estão no cerne de sistemas de informação./n
Estruturalmente, o Rabbit utiliza as queue's, que funcionam literalmente como filas, por exemplo, de um supermercado, em que o último a entrar na fila, será o último a sair, onde deve ser seguida a ordem de entrada na mesma./n
Pensando em um sistema de filas, obtem-se o publisher, que envia algo a fila e temos o consumer, que retira algo da fila, que poderá ser visto no código vinculado aqui./n

<b>Vantagens:</b>/n
  Escalabilidade a nível atômico;/n
  Manutenibilidade;/n
  Reutilização;/n
  Resistência à falhas;/n
  Flexibilidade de tecnologia;/n
<b>Desvantagens:</b>/n
  Perda de performance;/n
  Difícil implantação;/n
  /n
  <b>OBS:</b> Para que os serviços funcionem <u>perfeitamente</u>, o Consumer deve ser executado primeiramente, e logo após, o Publisher.
