-- CREATE TABLE contractors
-- (
--   id INT AUTO_INCREMENT,
--   company VARCHAR(255),
--   workers VARCHAR(255),

--   PRIMARY KEY (id)
-- );

-- CREATE TABLE jobs
-- (
--   id INT AUTO_INCREMENT,
--   name VARCHAR(255),
--   description VARCHAR(255),
--   location VARCHAR(255),

--   PRIMARY KEY (id)
-- );


-- CREATE TABLE bids
-- (
--   id INT AUTO_INCREMENT,
--   contractorId INT,
--   jobId INT,

--   PRIMARY KEY (id),

--   FOREIGN KEY (contractorId)
--     REFERENCES contractor(id)
--     ON DELETE CASCADE,

--   FOREIGN KEY (jobId)
--     REFERENCES job(id)
--     ON DELETE CASCADE
-- );