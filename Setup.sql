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
--   price INT,

--   PRIMARY KEY (id),

--   FOREIGN KEY (contractorId)
--     REFERENCES contractors(id)
--     ON DELETE CASCADE,

--   FOREIGN KEY (jobId)
--     REFERENCES jobs(id)
--     ON DELETE CASCADE
-- );

/* Find All of Collection */
-- SELECT * FROM bids;

/* Find by Value from Collection */
-- SELECT * FROM contractors WHERE workers=6 OR company="Jim's Electrical";

/* Add To Collection */
/* INSERT INTO dogs (name, age, hungry) VALUES ("spot", 2, true);
INSERT INTO dogs (name, age, hungry) VALUES ("rover", 5, true);
INSERT INTO dogs (name, age, hungry) VALUES ("max", 6, true);
INSERT INTO dogs (name, age, hungry) VALUES ("rin-tin-tin", 25, true); */

