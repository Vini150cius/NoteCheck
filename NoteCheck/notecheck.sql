-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 18/11/2024 às 22:49
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `notecheck`
--
CREATE DATABASE IF NOT EXISTS `notecheck` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `notecheck`;

DELIMITER $$
--
-- Procedimentos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_historico_listar` (IN `dataRetirada` DATE, IN `nomeAluno` VARCHAR(150), IN `numeroNotebook` INT)   BEGIN
    IF (dataRetirada IS NOT NULL) THEN
        SELECT * FROM uso_notebook WHERE data_retirada = dataRetirada;
    END IF;

    IF (nomeAluno IS NOT NULL) THEN
        SELECT * FROM uso_notebook WHERE nome_aluno LIKE CONCAT('%', nomeAluno, '%');
    END IF;

    IF (numeroNotebook IS NOT NULL) THEN
        SELECT * FROM uso_notebook WHERE numero_notebook = numeroNotebook;
    END IF;

    IF (dataRetirada IS NULL AND nomeAluno IS NULL AND numeroNotebook IS NULL) THEN
        SELECT * FROM uso_notebook;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_notebook_devolver` (IN `nomeAluno` VARCHAR(150), `numeroNotebook` INT, `horaEntrega` TIME, `idUso` INT)   BEGIN
    UPDATE notebook
    SET status_notebook = 'disponível'
    WHERE numero_notebook = numeroNotebook;

    UPDATE uso_notebook
    SET hora_entrega = horaEntrega
    WHERE id_uso = idUso;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_notebook_retirar` (IN `nomeAluno` VARCHAR(150), `curso` VARCHAR(100), `nomeProfessor` VARCHAR(50), `dataRetirada` DATE, `horaRetirada` TIME, `horaEntrega` TIME, `numeroNotebook` INT)   BEGIN
    INSERT INTO uso_notebook (nome_aluno, turma, professor_responsavel, data_retirada, hora_retirada, hora_entrega, numero_notebook) VALUES (nomeAluno, curso, nomeProfessor, dataRetirada, horaRetirada, horaEntrega, numeroNotebook);

UPDATE notebook SET status_notebook = 'em uso' WHERE numero_notebook = numeroNotebook;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_notebook_selecionar_id` (IN `nomeAluno` VARCHAR(150), `numeroNotebook` INT)   BEGIN 
	SELECT u.id_uso FROM uso_notebook u JOIN notebook n ON u.numero_notebook = n.numero_notebook WHERE u.nome_aluno = nomeAluno AND n.numero_notebook = numeroNotebook AND n.status_notebook = 'em uso';
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_notebook_verificar` (IN `numeroNotebook` INT)   BEGIN 
	SELECT status_notebook FROM notebook WHERE numero_notebook = numeroNotebook;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_professor_cadastrar` (IN `nomeProfessor` VARCHAR(50), `senhaProfessor` VARCHAR(20))   BEGIN 
	INSERT INTO professor (nome, senha) VALUES (nomeProfessor, senhaProfessor);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_professor_logar` (IN `nomeProfessor` VARCHAR(50), `senhaProfessor` VARCHAR(20))   BEGIN 
	SELECT id FROM professor WHERE nome = nomeProfessor AND senha = senhaProfessor;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estrutura para tabela `notebook`
--

CREATE TABLE `notebook` (
  `numero_notebook` int(11) NOT NULL,
  `status_notebook` enum('disponível','em uso','manutenção') DEFAULT 'disponível'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `notebook`
--

INSERT INTO `notebook` (`numero_notebook`, `status_notebook`) VALUES
(1, 'em uso'),
(2, 'em uso'),
(3, 'disponível'),
(4, 'disponível'),
(5, 'em uso'),
(6, 'disponível'),
(7, 'disponível'),
(8, 'em uso'),
(9, 'em uso'),
(10, 'disponível'),
(11, 'disponível'),
(12, 'disponível'),
(13, 'disponível'),
(14, 'em uso'),
(15, 'em uso'),
(16, 'disponível'),
(17, 'disponível'),
(18, 'disponível'),
(19, 'disponível'),
(20, 'disponível'),
(21, 'disponível'),
(22, 'disponível'),
(23, 'em uso'),
(24, 'em uso'),
(25, 'em uso'),
(26, 'disponível'),
(27, 'disponível'),
(28, 'disponível'),
(29, 'disponível'),
(30, 'disponível'),
(31, 'disponível'),
(32, 'disponível'),
(33, 'disponível'),
(34, 'disponível'),
(35, 'disponível'),
(36, 'em uso'),
(37, 'disponível'),
(38, 'disponível'),
(39, 'disponível'),
(40, 'em uso'),
(41, 'disponível'),
(42, 'em uso'),
(43, 'disponível'),
(44, 'em uso'),
(45, 'em uso'),
(46, 'disponível'),
(47, 'em uso'),
(48, 'disponível'),
(49, 'em uso'),
(50, 'em uso');

-- --------------------------------------------------------

--
-- Estrutura para tabela `professor`
--

CREATE TABLE `professor` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) DEFAULT NULL,
  `senha` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `professor`
--

INSERT INTO `professor` (`id`, `nome`, `senha`) VALUES
(1, 'magali', 'senha'),
(2, 'xu', 'xuzinhos'),
(3, 'yago', 'yago123'),
(4, 'q', 'q'),
(5, 'claudio', '45');

-- --------------------------------------------------------

--
-- Estrutura para tabela `uso_notebook`
--

CREATE TABLE `uso_notebook` (
  `id_uso` int(11) NOT NULL,
  `nome_aluno` varchar(150) NOT NULL,
  `turma` varchar(100) NOT NULL,
  `professor_responsavel` varchar(50) NOT NULL,
  `data_retirada` date NOT NULL,
  `hora_retirada` time NOT NULL,
  `hora_entrega` time DEFAULT NULL,
  `numero_notebook` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `uso_notebook`
--

INSERT INTO `uso_notebook` (`id_uso`, `nome_aluno`, `turma`, `professor_responsavel`, `data_retirada`, `hora_retirada`, `hora_entrega`, `numero_notebook`) VALUES
(1, 'thomas', 'Curso: Design de Interiores, Ano: 3º Ano', 'magali', '2024-10-29', '22:08:00', NULL, 24),
(2, 'thomas', 'Curso: Design de Interiores, Ano: 3º Ano', 'magali', '2024-10-29', '22:08:00', NULL, 24),
(3, 'thomas', 'Curso: Meio Ambiente, Ano: 2º Ano', 'magali', '2024-10-29', '22:15:00', NULL, 24),
(4, 'thomas', 'Curso: Design de Interiores, Ano: 2º Ano', 'magali', '2024-10-29', '22:15:00', NULL, 24),
(5, 'ibu', 'Curso: Hospedagem, Ano: 2º Ano', 'magali', '2024-10-29', '22:18:00', '18:02:00', 40),
(6, 'jose', 'Curso: Secretariado, Ano: 3º Ano', 'magali', '2024-10-29', '22:21:00', NULL, 23),
(7, 'paulo', 'Curso: Hospedagem, Ano: 3º Ano', 'magali', '2024-10-29', '22:23:00', '20:13:00', 36),
(8, 'thomas', 'Curso: Hospedagem, Ano: 3º Ano', 'magali', '2024-10-30', '18:45:00', NULL, 1),
(9, 'vinicius', 'Curso: Hospedagem, Ano: 2º Ano', 'magali', '2024-10-30', '21:01:00', NULL, 5),
(10, 'vinicius', 'Curso: Hospedagem, Ano: 2º Ano', 'magali', '2024-10-30', '21:03:00', NULL, 8),
(11, 'joão', 'Curso: Hospedagem, Ano: 3º Ano', 'magali', '2024-10-30', '21:05:00', NULL, 36),
(12, 'thom', 'Curso: Hospedagem, Ano: 2º Ano', 'magali', '2024-10-30', '21:07:00', NULL, 50),
(13, 'giola', 'Curso: Design de Interiores, Ano: 2º Ano', 'magali', '2024-10-30', '21:08:00', NULL, 42),
(14, 'gerson', 'Curso: Design de Interiores, Ano: 2º Ano', 'magali', '2024-11-07', '18:03:00', NULL, 40),
(15, 'otavio', 'Curso: Administração, Ano: Curso', 'magali', '2024-11-07', '11:11:00', '21:59:00', 48),
(16, 'giovanne', 'Curso: Hospedagem, Ano: 2º Ano', 'magali', '2024-11-15', '18:12:00', '00:00:00', 2),
(17, 'alguem', 'Curso: Meio Ambiente, Ano: 2º Ano', 'magali', '2024-11-15', '18:15:00', '00:00:00', 45),
(18, 'titan', 'Curso: Turismo Receptivo, Ano: Curso', 'magali', '2024-11-15', '18:18:00', '00:00:00', 49),
(19, 'rewr', 'Curso: Turismo Receptivo, Ano: Curso', 'magali', '2024-11-15', '18:24:00', '00:00:00', 15),
(20, 'yui', 'Curso: Meio Ambiente, Ano: 1º Ano', 'magali', '2024-11-15', '18:25:00', '00:00:00', 14),
(21, 'joy', 'Curso: Secretariado, Ano: 2º Ano', 'magali', '2024-11-15', '18:27:00', '00:00:00', 47),
(22, 'youe', 'Curso: Meio Ambiente, Ano: 1º Ano', 'magali', '2024-11-15', '18:29:00', '00:00:00', 9),
(23, 'huio', 'Curso: Design de Interiores, Ano: 2º Ano', 'magali', '2024-11-16', '17:14:00', '00:00:00', 44),
(24, 'yago', 'Curso: Meio Ambiente, Ano: 2º Ano', 'magali', '2024-11-18', '18:04:00', '18:05:00', 41);

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `notebook`
--
ALTER TABLE `notebook`
  ADD PRIMARY KEY (`numero_notebook`);

--
-- Índices de tabela `professor`
--
ALTER TABLE `professor`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `uso_notebook`
--
ALTER TABLE `uso_notebook`
  ADD PRIMARY KEY (`id_uso`),
  ADD KEY `numero_notebook` (`numero_notebook`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `professor`
--
ALTER TABLE `professor`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `uso_notebook`
--
ALTER TABLE `uso_notebook`
  MODIFY `id_uso` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `uso_notebook`
--
ALTER TABLE `uso_notebook`
  ADD CONSTRAINT `uso_notebook_ibfk_1` FOREIGN KEY (`numero_notebook`) REFERENCES `notebook` (`numero_notebook`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
